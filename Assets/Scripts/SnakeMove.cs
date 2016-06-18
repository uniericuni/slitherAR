using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeMove : Photon.MonoBehaviour {

	private float currentRotation;
	public float rotationSensitivity;
	public float initialRotationSensitivity = 200.0f;
	public float minRotationSensitivity = 80.0f;
	public float speed = 3.5f;
	public float score;

	public List<SnakeBody> bodyParts = new List<SnakeBody>();

	void Start()
	{
		running = false;
		rotationSensitivity = initialRotationSensitivity;
	}

	private Vector3 headV;

	void FixedUpdate()
	{
		if (photonView.isMine)
		{
			Move();
			transform.localScale = Vector3.SmoothDamp(transform.localScale, currentSize, ref headV, 0.5f);
			if( bodyParts.Count > 0)
			{
				for (int i = bodyParts.Count-1; i >= 0; i--)
				{
					if (i > 0)
						bodyParts [i].AddPath(bodyParts[i - 1].transform.position);
					else
						bodyParts [0].AddPath(transform.position);
					bodyParts [i].colorCode = i;
					bodyParts [i].overTime = bodyPartOverTimeFollow;
					bodyParts [i].transform.localScale = transform.localScale;
					bodyParts [i].running = running;
				}
			}
		}
	}
	     
	// Add SnakeBody when head collides with food
	void OnTriggerEnter(Collider other)
	{
		if (photonView.isMine)
		{
			if (other.transform.tag == "Food")
			{
				if (PhotonNetwork.isMasterClient)
					PhotonNetwork.Destroy(other.gameObject);
				else
					photonView.RPC("destroyFood", PhotonTargets.MasterClient, other.gameObject.GetPhotonView().viewID);
				
				if (SizeUp(orbCounter) == false)
				{
					float oldScore = score;
					score += other.GetComponent<FoodGrow> ().score;
					orbCounter = Mathf.RoundToInt (score);
					Vector3 currentPos;
					if (bodyParts.Count == 0)
						currentPos = transform.position;
					else
						currentPos = bodyParts[bodyParts.Count - 1].transform.position;

					for (int i = 0; i < (Mathf.RoundToInt(score) - Mathf.RoundToInt(oldScore)); i++) {
						SnakeBody newBodyPart = PhotonNetwork.Instantiate ("SnakeBody", currentPos, Quaternion.identity, 0).GetComponent<SnakeBody> ();
						newBodyPart.head = transform;
						bodyParts.Add (newBodyPart);
					}
				}
			} else if (other.transform.tag == "SnakeBody" && !other.GetComponent<SnakeBody> ().photonView.isMine) {
				CollideWithOtherBody ();
			}
		}
	}
	[PunRPC]
	void destroyFood(int foodID)
	{
		Debug.Log("RPC new food");
		PhotonNetwork.Destroy(PhotonView.Find(foodID));
	}

	void Update () {
		if (photonView.isMine)
		{
			//ColorSnake();
			Running();
			Scaling();
			UpdateRotationSensitivity ();
		}
	}

	void UpdateRotationSensitivity() {
		if (rotationSensitivity > minRotationSensitivity) {
			float delta = score / 2.0f;
			if (delta < initialRotationSensitivity - minRotationSensitivity)
				rotationSensitivity = initialRotationSensitivity - delta;
			else
				rotationSensitivity = minRotationSensitivity;
		}
	}

   // Movement by keys A & D
	private void Move()
	{
		Vector3 myPos = transform.position;
		Quaternion myRot = transform.rotation;

		if (Input.GetKey(KeyCode.A))
			currentRotation -= rotationSensitivity * Time.deltaTime;
		if (Input.GetKey(KeyCode.D))
			currentRotation += rotationSensitivity * Time.deltaTime;

		transform.position += transform.forward * speed * Time.deltaTime;
		transform.rotation = Quaternion.Euler(new Vector3(myRot.x, currentRotation, myRot.z));
	}

	// Count number of orbs and decide whether to size up or to add a new body part
	public int orbCounter;
	private int currentOrb;
	public int[] growOnThisOrb;
	private Vector3 currentSize = Vector3.one;
	public float growthRate = 0.1f;
	public float bodyPartOverTimeFollow = 0.19f;
	bool SizeUp(int x)
	{
		try
		{
			if (x == growOnThisOrb[currentOrb])
			{
				currentOrb++;
				return false;
			}
			else
			{
				return false;
			}
		}
		catch (System.Exception e)
		{
			print("No more growing from this point" + e.StackTrace.ToString());
		}
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
			PhotonNetwork.InstantiateSceneObject("smallfood", lastBodyPart.position, Quaternion.identity, 0, null);
		}
		else
		{
			photonView.RPC("foodFromBodyParts", PhotonTargets.MasterClient, bodyParts[bodyParts.Count - 1].photonView.viewID);
		}

		bodyParts.RemoveAt (lastIndex);
		PhotonNetwork.Destroy(lastBodyPart.gameObject);
		score -= 0.7f;
		orbCounter = Mathf.RoundToInt (score);
	}

	// Leave new food from the position of the body parts that are dropped
	[PunRPC]
	void foodFromBodyParts(int lastbodyID)
	{
		Debug.Log("rpc bp");
		GameObject toDestroy= PhotonView.Find(lastbodyID).gameObject;
		PhotonNetwork.InstantiateSceneObject("smallfood", toDestroy.transform.position, Quaternion.identity, 0, null);
	}
    
	// Scale body when body parts are lost
	public List<bool> scalingTrack;
	public int currentBodySize;
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

		bodyPartFollowTimeWalking = currentBodySize / 50.0f + followTimeSensitivity;
		bodyPartFollowTimeRunning = bodyPartFollowTimeWalking / 2;
	}

	void CollideWithOtherBody() {
		for (int i = 0; i < bodyParts.Count; i++) {
			Transform bodyPart = bodyParts [i].transform;

			if (PhotonNetwork.isMasterClient) {
				PhotonNetwork.InstantiateSceneObject ("LargeFood", bodyPart.position, Quaternion.identity, 0, null);
			} else {
				photonView.RPC ("foodFromDeadSnake", PhotonTargets.MasterClient, bodyParts [i].photonView.viewID);
			}
			PhotonNetwork.Destroy (bodyPart.gameObject);
		}
		//if (PhotonNetwork.isMasterClient)
		PhotonNetwork.Destroy(this.gameObject);
		bodyParts.Clear();
	}
	// Leave new food from the position of the dead snakes
	[PunRPC]
	void foodFromDeadSnake(int bodyID)
	{
		//Debug.Log("rpc bp");
		GameObject toDestroy= PhotonView.Find(bodyID).gameObject;
		PhotonNetwork.InstantiateSceneObject("LargeFood", toDestroy.transform.position, Quaternion.identity, 0, null);
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
			stream.SendNext(transform.localScale);
			//stream.SendNext(running);
		}
		else
		{
			transform.position = (Vector3)stream.ReceiveNext();
			transform.rotation = (Quaternion)stream.ReceiveNext();
			transform.localScale = (Vector3)stream.ReceiveNext();
			//running = (bool)stream.ReceiveNext();
		}
	}
}
