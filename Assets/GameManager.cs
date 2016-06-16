using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	private Hashtable playerBodies;
	private Hashtable playerHead;
	private Hashtable playerScore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updatePlayers( List<string> names)
	{
		foreach (string n in names)
		{
			if
		}
	}
	public void updateScore(string name, float score)
	{
		playerScore[name] = score; 
	}
}
