using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeBody : Photon.MonoBehaviour {

	public int colorCode;
    public Material Cyan;
    public Material White;
    public Material Purple;
	public float overTime;
	private int headID;
	private Transform head;

	private Queue<Vector3> Path;
	private Renderer colorRenderer;

	void Start() {
		Path = new Queue<Vector3>();
		overTime = 0.19f;
		colorCode = 0;
		colorRenderer = GetComponent<Renderer>();

		headID = (int)photonView.instantiationData[0];
		head = PhotonView.Find(headID).transform;

		transform.position = Vector3.SmoothDamp(transform.position, head.position, ref movementVelocity, overTime);
		transform.LookAt(head.position);
	}

	//[Range(0.0f,1.0f)]
	private Vector3 headV;
	void FixedUpdate()
	{
		if (photonView.isMine)
		{
			if (Path.Count > 0)
				MoveTo(Path.Dequeue());
		}
		///transform.localScale = Vector3.SmoothDamp(transform.localScale, head.gameObject.GetComponent<SnakeMove>().currentSize, ref headV, 0.5f);
	}
	void Update()
	{
		Coloring();

		//transform.FindChild("onfire").gameObject.SetActive(head.gameObject.GetComponent<SnakeMove>().running);
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

    private void Coloring ()
	{
		if (colorCode % 3 == 0)
			colorRenderer.material = Cyan;
		else if( colorCode % 3 == 1 )
            colorRenderer.material = Purple;
        else
            colorRenderer.material = White;
    }
	
	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
			//stream.SendNext(transform.localScale);
			stream.SendNext(colorCode);
		}
		else
		{
			transform.position = (Vector3)stream.ReceiveNext();
			transform.rotation = (Quaternion)stream.ReceiveNext();
			//transform.localScale = (Vector3)stream.ReceiveNext();
			colorCode = (int)stream.ReceiveNext();
		}
	}
}
