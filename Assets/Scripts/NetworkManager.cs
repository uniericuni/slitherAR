using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour {

	private GameObject imageTarget;
	private Text[] rankTexts;
    private string errorMessage;
    private string playerName;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.7");
        imageTarget = GameObject.Find("ImageTarget");
    }
    void Update()
    {
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

	private void addScore(float s)
	{

	}
	private void addBody(string n) { }
	/*
	[PunRPC]
	void updateGMScore(float score)
	{
		GM.updateScore(PhotonNetwork.playerName, score);
	}
	[PunRPC]
	void updateGMPlayers(List<string> names)
	{
		GM.updatePlayers(names);
	}
	*/
}