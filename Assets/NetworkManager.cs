using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour {

	private Text[] rankTexts;
    private string errorMessage;
    private string playerName;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.7");
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