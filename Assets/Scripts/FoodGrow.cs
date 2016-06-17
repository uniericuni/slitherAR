using UnityEngine;
using System.Collections;

public class FoodGrow : MonoBehaviour {

	public Vector3 startingSize = Vector3.zero;
	public Vector3 currentSize;

	void Awake() {
		transform.localScale = startingSize;
	}

	void Update() {
		currentSize = Vector3.Slerp (currentSize, new Vector3 (1f, 1f, 1f), Time.deltaTime * 5);
		transform.localScale = currentSize;
	}
}
