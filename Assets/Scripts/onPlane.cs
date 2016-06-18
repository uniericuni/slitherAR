using UnityEngine;
using System.Collections;

public class onPlane : MonoBehaviour {

	public GameObject boundingBoxCenter;
	public GameObject ARPlaneCenter;
	public float x;
	public float z;
	public float y;
	
	private Vector3 headPos;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {

		Debug.DrawRay(boundingBoxCenter.transform.position, boundingBoxCenter.transform.forward*10000f);
		if(Physics.Raycast(boundingBoxCenter.transform.position, boundingBoxCenter.transform.forward, out hit, 1000f)) {
			transform.position = hit.point;
			Debug.Log("head init ...");
		}
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		x = ARPlaneCenter.transform.position.x - transform.position.x;
		y = ARPlaneCenter.transform.position.y - transform.position.y;
		z = ARPlaneCenter.transform.position.z - transform.position.z;

		string str = x.ToString() + " , " + y.ToString() + " , " + z.ToString();
		Debug.Log(str);

	}
}
