using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviour {
    public InputField nameInput;
    public Button enterRoom;
    public Text rankName1;
    public Text rankName2;
    public Text rankName3;
    public Text rankName4;
    public Text rankName5;

    private Text[] rankTexts;
    private string errorMessage;
    private string playerName;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.7");
        rankTexts = new Text[5] { rankName1, rankName2, rankName3, rankName4, rankName5 };
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
}
