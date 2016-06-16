using UnityEngine;
using System.Collections;

public class SnakeManager : MonoBehaviour {
	public Rigidbody snake_body;
	public Rigidbody snake_head;
	private Transform lastPiece;
	// Use this for initialization
	void Start () {
		Rigidbody head = (Rigidbody)Instantiate (snake_head, transform.position, transform.rotation);
		lastPiece = head.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddBody () {
		Rigidbody new_body = (Rigidbody)Instantiate (snake_body, transform.position, transform.rotation);
		new_body.GetComponent<SmoothFollow> ().target = lastPiece;
		lastPiece = new_body.gameObject.transform;
	}
}
