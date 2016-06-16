using UnityEngine;
using System.Collections;

public class SnakeEat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "NormalFood") {
			Destroy (col.gameObject);
			GameObject.FindWithTag ("Snake").GetComponent<SnakeManager> ().transform.SendMessage("AddBody");
		}
	}
}
