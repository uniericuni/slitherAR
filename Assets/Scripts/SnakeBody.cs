using UnityEngine;
using System.Collections;

public class SnakeBody : MonoBehaviour {
	private int myOrder;
	private Transform head;

	void Start() {
		head = GameObject.FindGameObjectWithTag("SnakeHead").gameObject.transform;
		for (int i = 0; i < head.GetComponent<SnakeMove>().bodyParts.Count; i++) {
			if(gameObject == head.GetComponent<SnakeMove>().bodyParts[i].gameObject) {
				myOrder = i;
			}
		}
	}
	private Vector3 movementVelocity;
	[Range(0.0f,1.0f)]
	public float overTime = 0.5f;
	void FixedUpdate() {
		if (myOrder == 0) {
			transform.position = Vector3.SmoothDamp(transform.position, head.position, ref movementVelocity, overTime);
			transform.LookAt(head.transform.position);
		} else {
			transform.position = Vector3.SmoothDamp(transform.position, head.GetComponent<SnakeMove>().bodyParts[myOrder-1].position, ref movementVelocity, overTime);
			transform.LookAt(head.transform.position);
		}
	}
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
	
	}
}
