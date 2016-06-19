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
        snkHead.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
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
		snkBody.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
		return snkBody.transform;
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
