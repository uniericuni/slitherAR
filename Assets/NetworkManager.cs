﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : Photon.MonoBehaviour {

    public Button startButton;
    public InputField nameInput; 
    public Text[] rankTexts;
    private string errorMessage;
    private string playerName;
    private float spawnTimer;
    private Hashtable Score;
    private string first;
    private string second;
    private string third;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.7");
        Score = new Hashtable();
    }
    void FixedUpdate()
    {
        updateRank();
    }
    void Update()
    {
        // Spawning
        if (PhotonNetwork.isMasterClient)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer > 0.5f)
            {
                spawnFood();
                spawnTimer = 0f;
            }
        }
        //Scoreboard
        rankTexts[0].text = "1. " + first;
        rankTexts[1].text = "2. " + second;
        rankTexts[2].text = "3. " + third;

    }

    void OnJoinedLobby()
    {
        startButton.onClick.AddListener(JoinRoom);
    }

    private void JoinRoom()
    {
        if(nameInput.text.Length > 0)
        {
            RoomOptions roomOptions = new RoomOptions()
            {
                isVisible = false,
                maxPlayers = 20
            };
            PhotonNetwork.JoinOrCreateRoom("master", roomOptions, TypedLobby.Default);
        }
        startButton.enabled = false;
        nameInput.enabled = false;
    }

    void OnJoinedRoom()
    {
        SnakeMove Me = PhotonNetwork.Instantiate( "SnakeHead", transform.position, transform.rotation, 0).GetComponent<SnakeMove>();
        playerName = nameInput.text;
        PhotonNetwork.playerName = playerName;
        Me.NM = this;
        foreach (PhotonPlayer player in PhotonNetwork.playerList)
        {
            Score.Add(player.name, 0f);
        }
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

    public void updateScore (float score)
    {
        if (PhotonNetwork.isMasterClient)
            Score[playerName] = score;
        else photonView.RPC("updateMsterScore", PhotonTargets.MasterClient, score, playerName);
    }
    [PunRPC]
    void updateMasterScore(float score, string name)
    {
        Score[name] = score;
    }

    private void updateRank()
    {
        List<string> ranking = new List<string>();
        foreach (string name in Score.Keys)
        {
            int idx = 0;
            float playerScore = (float)Score[name];
            for (int i = 0; i < ranking.Count; i++)
            {
                if ((float)Score[ranking[i]] > playerScore)
                {
                    idx = i;
                    break;
                }
            }
            ranking.Insert(idx, name);
        }
        if( ranking.Count > 0)
            first = ranking[0];
        if (ranking.Count > 1)
            second = ranking[1];
        if (ranking.Count > 2)
            third = ranking[2];
    }

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(first);
            stream.SendNext(second);
            stream.SendNext(third);
        }
        else
        {
            first = (string)stream.ReceiveNext();
            second = (string)stream.ReceiveNext();
            third = (string)stream.ReceiveNext();
        }
    }
}