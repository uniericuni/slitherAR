using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeMove : Photon.MonoBehaviour {

	private float currentRotation;
	public float rotationSensitivity = 50.0f;
	public float speed = 3.5f;

	public List<SnakeBody> bodyParts = new List<SnakeBody>();
	
	void Start() { }

	private Vector3 headV;

	void FixedUpdate()
	{
		if (photonView.isMine)
		{
			Move();
			//transform.localScale = Vector3.SmoothDamp(transform.localScale, currentSize, ref headV, 0.5f);
			int partsCount = bodyParts.Count;
			if( partsCount > 1)
			{
				for (int i = 1; i < bodyParts.Count; i++)
				{
					if (i > 1)
						bodyParts[i].AddPath(bodyParts[i - 1].transform.position);
					else
						bodyParts[0].AddPath(transform.position);
					bodyParts[i].colorCode = i;
					bodyParts[i].overTime = bodyPartOverTimeFollow;
					//bodyParts[i].localScale = transform.localScale;
				}
			}
		}
	}

	// Add SnakeBody when head collides with food
	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "NormalFood")
		{
			PhotonNetwork.Destroy(other.gameObject);
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
				newBodyPart.myOrder = bodyParts.Count;
				bodyParts.Add(newBodyPart);
			}
		}
	}

	void Update () {
		/*if (photonView.isMine)
		{
			ColorSnake();
			Running();
			Scaling();
		}*/
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
	private int orbCounter;
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
	
	/*
	// Speed up
	private bool running;
	public float speedWhileRunning = 6.5f;
	public float speedWhileWalking = 3.4f;
	public float bodyPartFollowTimeRunning = 0.1f;
	public float bodyPartFollowTimeWalking = 0.19f;
	void Running() {
		SnakeGlow (running);

		if (bodyParts.Count > 2) {
			if (Input.GetMouseButtonDown (0)) {
				speed = speedWhileRunning;
				running = true;
				bodyPartOverTimeFollow = bodyPartFollowTimeRunning;
			}
			if (Input.GetMouseButtonUp (0)) {
				speed = speedWhileWalking;
				running = false;
				bodyPartOverTimeFollow = bodyPartFollowTimeWalking;
			}
		} else {
			speed = speedWhileWalking;
			running = false;
			bodyPartOverTimeFollow = bodyPartFollowTimeWalking;
		}

		if (running) {
			StartCoroutine ("LoseBodyParts");
		} else {
			bodyPartOverTimeFollow = bodyPartFollowTimeWalking;
		}
	}

	// Couroutine: Lose body parts when speeding up.
	IEnumerator LoseBodyParts(){
		yield return new WaitForSeconds (0.5f);

		int lastIndex = bodyParts.Count - 1;
		Transform lastBodyPart = bodyParts [lastIndex].transform;

		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.InstantiateSceneObject("food", lastBodyPart.position, Quaternion.identity, 0, new Object[0]);
		}
		else
		{
			photonView.RPC("foodFromBodyParts", PhotonTargets.All, lastBodyPart.position, Quaternion.identity);
		}

		bodyParts.RemoveAt (lastIndex);
		PhotonNetwork.Destroy (lastBodyPart.gameObject);
		orbCounter--;
		StartCoroutine("LoseBodyParts");
	}
	// Leave new food from the position of the body parts that are dropped
	[PunRPC]
	void foodFromBodyParts(Vector3 pos, Quaternion rot)
	{
		if(PhotonNetwork.isMasterClient)
			PhotonNetwork.InstantiateSceneObject("food", pos, rot, 0, new Object[0]);
	}

	// Updates the body size and follow speed.


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
		foreach (Transform bodyPart_x in bodyParts) {
			bodyPart_x.FindChild("onfire").gameObject.SetActive(isRunning);
		}
	}
	*/

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
		}
		else
		{
			transform.position = (Vector3)stream.ReceiveNext();
			transform.rotation = (Quaternion)stream.ReceiveNext();
		}
	}
}
