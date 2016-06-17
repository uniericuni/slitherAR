using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeBody : Photon.MonoBehaviour {

	public int colorCode;
	//public Transform localScale;
	public float overTime;
	public Transform head;
	public int myOrder;
	private Queue<Vector3> Path;
	private Material color;

	void Start() {
		Path = new Queue<Vector3>();
		overTime = 0.2f;
		colorCode = 0;
		color = GetComponent<Renderer>().material;
		head = GameObject.FindGameObjectWithTag("SnakeHead").gameObject.transform;
		transform.position = Vector3.SmoothDamp(transform.position, head.position, ref movementVelocity, overTime);
		transform.LookAt(head.position);
	}

	//[Range(0.0f,1.0f)]

	void FixedUpdate()
	{
		if(photonView.isMine)
			if ( Path.Count > 0)
				MoveTo(Path.Dequeue());
	}
	void Update()
	{
		Coloring();
	}

	private Vector3 movementVelocity;
	public void AddPath (Vector3 pos)
	{
		Path.Enqueue(pos);
	}

	private void MoveTo ( Vector3 pos )
	{
		transform.position = Vector3.SmoothDamp(transform.position, pos, ref movementVelocity, overTime);
		transform.LookAt(pos);
	}

	public Material skinColor_1, skinColor_2;

	private void Coloring ()
	{
		if (colorCode % 2 == 0)
			color = skinColor_1;
		else
			color = skinColor_2;
	}
	
	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
			stream.SendNext(colorCode);
		}
		else
		{
			transform.position = (Vector3)stream.ReceiveNext();
			transform.rotation = (Quaternion)stream.ReceiveNext();
			colorCode = (int)stream.ReceiveNext();
		}
	}
}
