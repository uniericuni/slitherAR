using UnityEngine;
using System.Collections;

public class onTarget : MonoBehaviour {

	public GameObject boundingBoxCenter;
    public GameObject boundingBoxBoundary;
	public GameObject imageTarget;
	public GameObject ARPlane;
	private Transform center, boundary;
	private RaycastHit hitCenter, hitBoundary;
	private Vector3 initScale = new Vector3(0.05f, 0.05f, 0.05f);

	// Use this for initialization
	void Start () {

		boundingBoxCenter = GameObject.Find("BoundingBoxCenter");
        boundingBoxBoundary = GameObject.Find("BoundingBoxBoundary");
		imageTarget = GameObject.Find("ImageTarget");
		ARPlane = GameObject.Find("ARPlane");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		center = boundingBoxCenter.transform;
		boundary = boundingBoxBoundary.transform;
		if( (Physics.Raycast(center.position, center.forward, out hitCenter)) && hitCenter.transform.tag=="ARPlane" ){
			transform.position = hitCenter.point;
			transform.forward = hitCenter.normal;
			if(transform.localScale.x <= 0.02f){
				transform.localScale = initScale;
				Debug.Log("scale reset");
			}
			else{
				transform.localScale = Vector3.Slerp( transform.localScale, new Vector3(0f,0f,0f), Time.deltaTime);
			}
		}
		else
			Debug.Log("onTarget, bouding box not complete ...");

	}
}
