using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour {
    public InputField nameInput;
    public Button enterRoom;
	public GameManager GM;

    private Text[] rankTexts;
    private string errorMessage;
    private string playerName;

    void Start()
    {
		GM = gameObject.GetComponent<GameManager>();
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
        //PhotonNetwork.Instantiate( "balla", transform.position, transform.rotation, 0); 
    }

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
}