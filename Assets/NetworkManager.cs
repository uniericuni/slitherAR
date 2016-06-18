using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour {

	private Text[] rankTexts;
    private string errorMessage;
    private string playerName;
    private float spawnTimer;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.7");
    }
    void Update()
    {
        if (PhotonNetwork.isMasterClient)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer > 0.5f)
            {
                spawnFood();
                spawnTimer = 0f;
            }
        }
    }

    void OnJoinedLobby()
    {
        RoomOptions roomOptions = new RoomOptions()
        {
            isVisible = false,
            maxPlayers = 20
        };
        PhotonNetwork.JoinOrCreateRoom( "master", roomOptions, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate( "SnakeHead", transform.position, transform.rotation, 0); 
    }

	public void destroyFood(GameObject food)
	{
		PhotonNetwork.Destroy(food);
	}
	public Transform instantiateBody(Vector3 pos, Quaternion rot)
	{
		return PhotonNetwork.Instantiate("SnakeBody", pos, rot, 0).transform;
	}


    private void spawnFood()
    {
        float spawnSeed = Random.Range(0,6);
        string toSpawn;
        if (spawnSeed < 3) toSpawn = "smallFood";
        else if (spawnSeed < 5) toSpawn = "food";
        else toSpawn = "LargeFood";
        Vector3 randPos = new Vector3(Random.Range(-30f, 30f), 0.6f, Random.Range(-30f, 30f));
        PhotonNetwork.InstantiateSceneObject( toSpawn, randPos, Quaternion.identity, 0, null);
    }
}