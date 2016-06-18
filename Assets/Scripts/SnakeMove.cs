using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeMove : Photon.MonoBehaviour {

	private float currentRotation;
	public float rotationSensitivity = 50.0f;
	public float speed = 3.5f;

	public List<SnakeBody> bodyParts = new List<SnakeBody>();
	private GameObject BoundingMgrObj;
	private boundingMgr boundingMgr;
	
	void Start()
	{
		running = false;
		BoundingMgrObj = GameObject.Find("BoundingMgr");
	}

	private Vector3 headV;

	void FixedUpdate()
	{
		planeNorm = ARPlane.transform.up;
		transform.forward = Vector3.Normalize( transform.forward - Vector3.Project( transform.forward, planeNorm.normalized ) );
		if (photonView.isMine)
		{
			boundingTest();
			Move();
			transform.localScale = Vector3.SmoothDamp(transform.localScale, currentSize, ref headV, 0.5f);
			if( bodyParts.Count > 0)
			{
				for (int i = bodyParts.Count-1; i >= 0; i--)
				{
					if (i > 0)
						bodyParts[i].AddPath(bodyParts[i - 1].transform.position);
					else
						bodyParts[0].AddPath(transform.position);
					bodyParts[i].colorCode = i;
					bodyParts[i].overTime = bodyPartOverTimeFollow;
					bodyParts[i].transform.localScale = transform.localScale;
				}
			}
		}
		transform.localScale = new Vector3(0.1f,0.1f,0.1f);
	}
	     
	// Add SnakeBody when head collides with food
	void OnTriggerEnter(Collider other)
	{
		if (photonView.isMine)
		{
			if (other.transform.tag == "NormalFood")
			{
				if (PhotonNetwork.isMasterClient)
					PhotonNetwork.Destroy(other.gameObject);
				else
					photonView.RPC("destroyFood", PhotonTargets.Others, other.gameObject.GetPhotonView().viewID);
				if (SizeUp(orbCounter) == false)
				{
					orbCounter++;
					Vector3 currentPos;
					if (bodyParts.Count == 0)
						currentPos = transform.position;
					else
						currentPos = bodyParts[bodyParts.Count - 1].transform.position;

					SnakeBody newBodyPart = PhotonNetwork.Instantiate("SnakeBody", currentPos, Quaternion.identity, 0).GetComponent<SnakeBody>();
					newBodyPart.head = transform;
					bodyParts.Add(newBodyPart);
				}
			}
		}
	}
	[PunRPC]
	void destroyFood(int foodID)
	{
		Debug.Log("RPC new food");
		if (PhotonNetwork.isMasterClient)
			PhotonNetwork.Destroy(PhotonView.Find(foodID));
	}

	void Update () {
		if (photonView.isMine)
		{
			//ColorSnake();
			Running();
			Scaling();
		}
		SnakeGlow (running);
	}


   // Movement by keys A & D
	private void Move()
	{
		Vector3 myPos = transform.position;
		Quaternion myRot = transform.rotation;

		if (Input.GetKey(KeyCode.A)){
			currentRotation -= rotationSensitivity * Time.deltaTime;
			Debug.Log("turning left ...");
		
		}
		if (Input.GetKey(KeyCode.D)) {
			currentRotation += rotationSensitivity * Time.deltaTime;
			Debug.Log("turning right ...");
		}

		if ((Input.GetKey(KeyCode.A)) || (lrValue < 0.0f)){
			currentRotation -= rotationSensitivity * Time.deltaTime;
			Debug.Log("turning left ...");
		
		}
		else if ((Input.GetKey(KeyCode.D)) || (lrValue > 0.0f)) {
			currentRotation += rotationSensitivity * Time.deltaTime;
			Debug.Log("turning right ...");
		}
		
		transform.position += transform.forward * speed * Time.deltaTime;
		transform.rotation = Quaternion.Euler(new Vector3(myRot.x, currentRotation, myRot.z));
	}

	// Count number of orbs and decide whether to size up or to add a new body part
	private int orbCounter;
	private int currentOrb;
	public int[] growOnThisOrb;
	private Vector3 currentSize = Vector3.one;
	public float growthRate = 0.1f;
	public float bodyPartOverTimeFollow = 0.19f;
	bool SizeUp(int x)
	{/*
		try
		{
			if (x == growOnThisOrb[currentOrb])
			{
				currentOrb++;
				return true;
			}
			else
			{
				return false;
			}
		}
		catch (System.Exception e)
		{
			print("No more growing from this point" + e.StackTrace.ToString());
		}*/
		return false;
	}
	
	
	// Speed up
	private bool running;
	public float speedWhileRunning = 6.5f;
	public float speedWhileWalking = 3.4f;
	public float bodyPartFollowTimeRunning = 0.1f;
	public float bodyPartFollowTimeWalking = 0.19f;
	void Running() {
        if (bodyParts.Count > 2 
            && Input.GetMouseButtonDown(0)
            && !running) {
			speed = speedWhileRunning;
			running = true;
			bodyPartOverTimeFollow = bodyPartFollowTimeRunning;
            InvokeRepeating("LoseBodyParts", 0f, 0.5f);
        } else if (Input.GetMouseButtonUp(0) || bodyParts.Count <= 2) {
			speed = speedWhileWalking;
			running = false;
			bodyPartOverTimeFollow = bodyPartFollowTimeWalking;
            CancelInvoke("LoseBodyParts");
        }
	}
    
	// Couroutine: Lose body parts when speeding up.
	private void LoseBodyParts(){

		int lastIndex = bodyParts.Count - 1;
		Transform lastBodyPart = bodyParts [lastIndex].transform;

		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.InstantiateSceneObject("food", lastBodyPart.position, Quaternion.identity, 0, null);
		}			
		else
			photonView.RPC("foodFromBodyParts", PhotonTargets.Others);

		bodyParts.RemoveAt (lastIndex);
		PhotonNetwork.Destroy(lastBodyPart.gameObject);
		orbCounter--;
	}

	// Leave new food from the position of the body parts that are dropped
	[PunRPC]
	void foodFromBodyParts()
	{
		Debug.Log("rpc bp");
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.InstantiateSceneObject("food", bodyParts[bodyParts.Count - 1].transform.position, Quaternion.identity, 0, null);
		}
	}
    
	// Scale body when body parts are lost
	public List<bool> scalingTrack;
	private int currentBodySize;
	public float followTimeSensitivity;
	public float scaleSensitivity = 0.22f;
	void Scaling() {
		scalingTrack = new List<bool> (new bool[growOnThisOrb.Length]);
		currentBodySize = 0;
		for (int i = 0; i < growOnThisOrb.Length; i++) {
			if (orbCounter >= growOnThisOrb [i]) {
				scalingTrack [i] = !scalingTrack [i];
				currentBodySize++;
			}
		}

		currentSize = new Vector3(
			1 + (currentBodySize * scaleSensitivity),
			1 + (currentBodySize * scaleSensitivity),
			1 + (currentBodySize * scaleSensitivity)
		);

		bodyPartFollowTimeWalking = currentBodySize / 100.0f + followTimeSensitivity;
		bodyPartFollowTimeRunning = bodyPartFollowTimeWalking / 2;
	}
    
    
	// Glow when running
	void SnakeGlow(bool isRunning) {
		foreach ( SnakeBody body in bodyParts) {
            body.transform.FindChild("onfire").gameObject.SetActive(isRunning);
        }
    }
	

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
			stream.SendNext(transform.localScale);
			stream.SendNext(running);
		}
		else
		{
			transform.position = (Vector3)stream.ReceiveNext();
			transform.rotation = (Quaternion)stream.ReceiveNext();
			transform.localScale = (Vector3)stream.ReceiveNext();
			running = (bool)stream.ReceiveNext();
		}
	}

	// ----------------- ERIC ----------------- //

	public GameObject boundingBoxCenter;
	public GameObject ARPlane;
	public float lrValue;

	private Vector3 objFront;
	private GameObject gameMgr;
	private const float turningVec = 230;
	private Transform center;
	private Vector3 dist, back, backPerpendic, planeNorm; 
	private RaycastHit hitCenter;
	private bool hit;

	void boundingTest() {
		
		// bounding box illustrating
		if (!photonView.isMine){
			lrValue = 0f;
			return;
		}
		objFront = transform.forward;
		center = boundingBoxCenter.transform;
		
		// debugging raycast draw
		Debug.DrawRay(center.position, center.forward*10000f);
		
		// bounding
		
		if( !(Physics.Raycast(center.position, center.forward, out hitCenter)) ){
			lrValue = 0f;
			Debug.Log("bouding box not complete ...");
		}
		else{
			float x = hitCenter.point.x-transform.position.x;
			float z = hitCenter.point.z-transform.position.z;
			if( x*x + z*z > 100f) {
				dist = (transform.position - hitCenter.point);
				// back = objFront;
				backPerpendic = Vector3.Project(dist, objFront) - dist;
				lrValue = Vector3.Dot(Vector3.Cross(objFront, backPerpendic), planeNorm);
				Debug.Log("snake turning ... "+lrValue.ToString() + " |dist: "+dist.x.ToString() + ","+dist.y.ToString()+","+dist.z.ToString()+" |backPerpend: "+backPerpendic.x.ToString() + ","+backPerpendic.y.ToString()+","+backPerpendic.z.ToString() );
			}
			else{
				Debug.Log("snake in center zone...");
				lrValue = 0f;
			}
		}

	}

}
