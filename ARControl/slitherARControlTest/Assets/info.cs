using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class info : MonoBehaviour {

	string Info;
	public GameObject imageTarget;
	public Text posInfo;
	Vector3 pos1, pos2, pos3, pos4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*pos1 = cube.transform.position;
		pos2 = sphere.transform.position;
		pos3 = cube.transform.localPosition;
		pos4 = sphere.transform.localPosition;
		Info = "cube position: " + pos1.x.ToString() + " , " + pos1.y.ToString() + " , " + pos1.z.ToString() +
			   "sphere position: " + pos2.x.ToString() + " , " + pos2.y.ToString() + " , " + pos2.z.ToString() +
			   "cube local position: " + pos3.x.ToString() + " , " + pos3.y.ToString() + " , " + pos3.z.ToString() +
			   "sphere local position: " + pos4.x.ToString() + " , " + pos4.y.ToString() + " , " + pos4.z.ToString();*/
		pos1 = imageTarget.transform.TransformPoint(new Vector3 (0f,1f,0f));
		Info = "image norm: " + pos1.x.ToString() + " , " + pos1.y.ToString() + " , " + pos1.z.ToString();

		posInfo.text = Info;
		
	}
}
