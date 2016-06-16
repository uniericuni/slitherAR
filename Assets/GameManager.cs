using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	private List<string> playerNames;
	private Hashtable playerBodies;
	private Hashtable playerScore;

	// Use this for initialization
	void Start () {
	
	}


	void FixedUpdate()
	{
		MoveBodies();
	}

	void Update () {
	
	}

	public void updatePlayers( List<string> names)
	{
		foreach (string n in names)
		{
			if (!playerNames.Contains(n))
			{
				playerNames.Add(n);
				playerBodies.Add(n, new List<Transform>());
				playerScore.Add(n, 0f);
			}
		}
	}
	public void updateScore(string name, float score)
	{
		playerScore[name] = score; 
	}
	public void addBody(string n, Transform t)
	{
		/*
		 ... = instantiate a body on t
		playerBodies[n].Add(...)
		 */
	}

	private void MoveBodies()
	{
		//wei fang god
		foreach ( string bodies in playerBodies.Values)
		{
			/*
			for (i = 0 ... bodies.size)
			{
				bodies[i].transform = bodies[i-1]......大概是這樣吧
			}
			*/
		}
	
	}
}
