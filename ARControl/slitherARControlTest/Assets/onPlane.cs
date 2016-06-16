using UnityEngine;
using System.Collections;

public class onPlane : MonoBehaviour {

	public GameObject battlePlane;
	Vector3 planeNorm;
	Vector3 planeOrigin;
	Vector3 objPos;
	float x;
	float z;
	float y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		objPos = transform.position;
		planeNorm = battlePlane.transform.TransformPoint(new Vector3 (0f,1f,0f));
		planeOrigin = battlePlane.transform.TransformPoint(new Vector3 (0f,0f,0f));
		x = planeNorm.x * (planeNorm.x-objPos.x);
		z = planeNorm.z * (planeNorm.z-objPos.z);
		y = planeOrigin.y + (x+z)/planeNorm.y;
		objPos.y = y;
		transform.position = objPos;

	}
}
