using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeMove : Photon.MonoBehaviour {
	private float currentRotation;
	public float rotationSensitivity = 50.0f;
	public float speed = 3.5f;

	public List<Transform> bodyParts = new List<Transform>();


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{	
		Move();
		/*if (photonView.isMine)
		{
			Move();
		}*/
	}

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

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting) {
			stream.SendNext (transform.position);
			stream.SendNext (transform.rotation);
		} else {
			transform.position = (Vector3)stream.ReceiveNext ();
			transform.rotation = (Quaternion)stream.ReceiveNext ();
		}
	}
	public Transform bodyObject;
	void OnCollisionEnter (Collision other) {
		if (other.transform.tag == "NormalFood") {
			Destroy (other.gameObject);
			if (bodyParts.Count == 0) {
				Vector3 currentPos = transform.position;
				Transform newBodyPart = Instantiate (bodyObject, currentPos, Quaternion.identity) as Transform;
				bodyParts.Add (newBodyPart);
			} else {
				Vector3 currentPos = bodyParts[bodyParts.Count-1].position;
				Transform newBodyPart = Instantiate (bodyObject, currentPos, Quaternion.identity) as Transform;
				bodyParts.Add (newBodyPart);
			}
		}
	}
}
