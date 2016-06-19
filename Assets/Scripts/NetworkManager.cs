using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour {

    private GameObject imageTarget;
	private Text[] rankTexts;
    private string errorMessage;
    private string playerName;
    private float spawnTimer;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.7");
        imageTarget = GameObject.Find("ImageTarget");
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
        GameObject snkHead = PhotonNetwork.Instantiate( "SnakeHead", imageTarget.transform.position, imageTarget.transform.rotation, 0); 
        snkHead.transform.SetParent(imageTarget.transform, false);
        SnakeMove move = snkHead.GetComponent<SnakeMove>();
        move.boundingBoxCenter = GameObject.Find("BoundingBoxCenter");
        move.ARPlane = GameObject.Find("ARPlane");
    }

	public void destroyFood(GameObject food)
	{
		PhotonNetwork.Destroy(food);
	}

	public Transform instantiateBody(Vector3 pos, Quaternion rot)
	{
		GameObject snkBody = PhotonNetwork.Instantiate("SnakeBody", pos, rot, 0);
		snkBody.transform.SetParent(imageTarget.transform, false);
		return snkBody.transform;
	}


    private void spawnFood()
    {
        float spawnSeed = Random.Range(0,100);
        string toSpawn;
        if (spawnSeed < 20) toSpawn = "smallFood";
        else if (spawnSeed < 95) toSpawn = "food";
        else toSpawn = "LargeFood";
        Vector3 randPos = new Vector3(Random.Range(-1.5f, 1.5f), 0.0f, Random.Range(-1.5f, 1.5f));
        //PhotonNetwork.InstantiateSceneObject( toSpawn, randPos, Quaternion.identity, 0, null);
        GameObject food = PhotonNetwork.InstantiateSceneObject( toSpawn, randPos, Quaternion.identity, 0, null);
        food.transform.SetParent(imageTarget.transform, false);
    }
}
