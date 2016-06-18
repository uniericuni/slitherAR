﻿using UnityEngine;
using System.Collections;

public class boundingMgr : MonoBehaviour {

	public GameObject boundingBoxCenter;
	public GameObject boundingBoxVertex1;
	public GameObject boundingBoxVertex2;
	public GameObject boundingBoxVertex3;
	public GameObject boundingBoxVertex4;
	public GameObject boundedObject;
	public GameObject ARPlane;
	public float lrValue;
	public Vector3 vec;

	private const float turningVec = 230;
	private Transform center;
	private Transform vertex1, vertex2, vertex3, vertex4;
	private Vector3 dist, back, backPerpendic, planeNorm; 
	private RaycastHit hitCenter;
	private RaycastHit hitVertex1, hitVertex2, hitVertex3, hitVertex4;
	private bool hit0, hit1, hit2, hit3, hit4;
	private float currentRotation;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		// bounding box illustrating
		center = boundingBoxCenter.transform;
		vertex1 = boundingBoxVertex1.transform;
		vertex2 = boundingBoxVertex2.transform;
		vertex3 = boundingBoxVertex3.transform;
		vertex4 = boundingBoxVertex4.transform;
		planeNorm = ARPlane.transform.forward;

		// debugging raycast draw
		Debug.DrawRay(center.position, center.forward*10000f);
		
		// bounding
		hit0 = Physics.Raycast(center.position, center.forward, out hitCenter);
		hit1 = Physics.Raycast(vertex1.position, vertex1.forward, out hitVertex1);
		hit2 = Physics.Raycast(vertex2.position, vertex2.forward, out hitVertex2);
		hit3 = Physics.Raycast(vertex3.position, vertex3.forward, out hitVertex3);
		hit4 = Physics.Raycast(vertex4.position, vertex4.forward, out hitVertex4);
		if( !(hit0 & hit1 & hit2 & hit3 & hit4) ){
			Debug.Log("bouding box not complete ...");
		}
		else{
			if( hitCenter.point != boundedObject.transform.position ){
				Debug.Log("snake turning ...");
				dist = (boundedObject.transform.position - hitCenter.point);
				back = -1*dist - vec;
				backPerpendic = back - Vector3.Project(back, vec);
				lrValue = Vector3.Dot(Vector3.Cross(vec, backPerpendic), planeNorm);
				if(lrValue < 0)
					Debug.Log("turning right ...");
				else
					Debug.Log("turning left ...");
			}
			else{
				Debug.Log("snake on center ...");
			}
		}
	}
	
}
