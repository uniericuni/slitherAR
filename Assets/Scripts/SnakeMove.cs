using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeMove : Photon.MonoBehaviour {

	private float currentRotation;
	public float rotationSensitivity = 50.0f;
	public float speed = 3.5f;

	public List<Transform> bodyParts = new List<Transform>();


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		ColorSnake ();
		Running ();
	}

	void FixedUpdate()
	{	
		if (photonView.isMine) {
		    Move();
		    UpdateBodyAttributes ();
        }
    }

	// Add skin colors for snake
	public Material skinColor_1, skinColor_2;
	void ColorSnake() {
		for (int i = 0; i < bodyParts.Count; i++) {
			if (i % 2 == 0) {
				bodyParts [i].GetComponent<Renderer> ().material = skinColor_1;
			} else {
				bodyParts [i].GetComponent<Renderer> ().material = skinColor_2;
			}
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
	private int orbCounter;
	private int currentOrb;
	public int [] growOnThisOrb;
	private Vector3 currentSize = Vector3.one;
	public float growthRate = 0.1f;
	public float bodyPartOverTimeFollow = 0.19f;
	bool SizeUp (int x) {
		try {
			if (x == growOnThisOrb [currentOrb]) {
				currentOrb++;
				return true;
			} else {
				return false;
			}
		} catch (System.Exception e) {
			print ("No more growing from this point" + e.StackTrace.ToString ());
		}
		return false;
	}


	// Add SnakeBody when head collides with food
	public Transform bodyObject;
	void OnCollisionEnter (Collision other) {
		if (other.transform.tag == "NormalFood") {
			PhotonNetwork.Destroy (other.gameObject);
			//orbCounter++;

			if (SizeUp (orbCounter) == false) {
				if (bodyParts.Count == 0) {
					orbCounter++;
					Vector3 currentPos = transform.position;
				    Transform newBodyPart = PhotonNetwork.Instantiate( "SnakeBody" , currentPos, Quaternion.identity, 0).transform;
					//newBodyPart.localScale = currentSize;
					//newBodyPart.GetComponent<SnakeBody> ().overTime = bodyPartOverTimeFollow;
					bodyParts.Add (newBodyPart);
				} else {
					Vector3 currentPos = bodyParts [bodyParts.Count - 1].position;
				    Transform newBodyPart = PhotonNetwork.Instantiate( "SnakeBody" , currentPos, Quaternion.identity, 0).transform;
					//newBodyPart.localScale = currentSize;
					//newBodyPart.GetComponent<SnakeBody> ().overTime = bodyPartOverTimeFollow;
					bodyParts.Add (newBodyPart);
				}
			} else {
				currentSize += Vector3.one * growthRate;
				bodyPartOverTimeFollow += 0.04f;
				transform.localScale = currentSize;

				foreach (Transform bodyPart_x in bodyParts) {
					bodyPart_x.localScale = currentSize;
					bodyPart_x.GetComponent<SnakeBody> ().overTime = bodyPartOverTimeFollow;
				}
			}
		}
	}

	// Speed up
	private bool running;
	public float speedWhileRunning = 6.5f;
	public float speedWhileWalking = 3.4f;
	public float bodyPartFollowTimeRunning = 0.1f;
	public float bodyPartFollowTimeWalking = 0.19f;
	void Running() {
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
		/*
		if (running) {
			StartCoroutine("LoseBodyParts")
		}*/
	}

	void UpdateBodyAttributes () {
		foreach (Transform bodyPart_x in bodyParts) {
			bodyPart_x.localScale = currentSize;
			bodyPart_x.GetComponent<SnakeBody> ().overTime = bodyPartOverTimeFollow;
		}
	}
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
