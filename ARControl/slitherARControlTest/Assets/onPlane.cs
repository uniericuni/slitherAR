using UnityEngine;
using System.Collections;

public class onPlane : MonoBehaviour {

	public GameObject cube;
	Vector3 planeNorm;
	Vector3 planeOrigin;
	Vector3 objPos;
	public float x;
	public float z;
	public float y;
	RaycastHit hit;
	float time;

	// Use this for initialization
	void Start () {

		time = 0f;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(Physics.Raycast(cube.transform.position, new Vector3(0, -1f, 0), out hit)) {
			objPos = hit.point;
		}
		if(Physics.Raycast(cube.transform.position, new Vector3(0, 1f, 0), out hit)) {
			objPos = hit.point;
		}
		transform.position = objPos;
		/*planeNorm = Vector3.Normalize(battlePlane.transform.TransformPoint(new Vector3 (0f,1f,0f)));
		planeOrigin = battlePlane.transform.TransformPoint(new Vector3 (0f,0f,0f));
		x = planeNorm.x * (planeNorm.x-objPos.x);
		z = planeNorm.z * (planeNorm.z-objPos.z);

		y = planeOrigin.y + (x+z)/planeNorm.y;
		objPos.y = y;
		transform.position = objPos;
		time += 0.1f;
		transform.position = planeOrigin + new Vector3(planeNorm.x*time, planeNorm.y*time, planeNorm.z*time); */

	}
}
