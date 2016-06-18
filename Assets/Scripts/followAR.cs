using UnityEngine;
using System.Collections;

public class followAR : MonoBehaviour {

	public GameObject ARTag;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = ARTag.transform.position;
		transform.rotation = ARTag.transform.rotation;
	
	}
}
