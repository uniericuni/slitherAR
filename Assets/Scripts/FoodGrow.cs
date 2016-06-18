using UnityEngine;
using System.Collections;

public class FoodGrow : MonoBehaviour {

	public Vector3 startingSize = Vector3.zero;
	public Vector3 currentSize;
	public float score = 1.0f;
	private Vector3 targetSize = new Vector3(1.0f, 1.0f, 1.0f);

	void Awake() {
		transform.localScale = startingSize;
		targetSize *= 1.0f + score * 0.1f;
	}

	void Update() {
		currentSize = Vector3.Slerp (currentSize, targetSize, Time.deltaTime * 5);
		transform.localScale = currentSize;
	}
}
