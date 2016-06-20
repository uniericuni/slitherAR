using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : Photon.MonoBehaviour {

    public Button startButton;
    public InputField nameInput; 
    public Text[] rankTexts;
    public Canvas ui;

    private GameObject imageTarget;

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
        imageTarget = GameObject.Find("ImageTarget");
        Score = new Hashtable();
    }
    void FixedUpdate()
    {
        updateRank();
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
            rankTexts[0].text = "1. " + first;
            rankTexts[1].text = "2. " + second;
            rankTexts[2].text = "3. " + third;
        }
    }

    void OnJoinedLobby()
    {
        startButton.onClick.AddListener(JoinRoom);
    }

    void JoinRoom()
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
        //startButton.enabled = false;
        startButton.gameObject.SetActive(false);
        //nameInput.enabled = false;
        nameInput.gameObject.SetActive(false);
        //ui.enabled = false;
    }

    void OnJoinedRoom()
    {
        GameObject snkHead = PhotonNetwork.Instantiate( "SnakeHead", imageTarget.transform.position, imageTarget.transform.rotation, 0); 
        SnakeMove me = snkHead.GetComponent<SnakeMove>();
        playerName = nameInput.text;
        PhotonNetwork.playerName = playerName;
        me.NM = this;
        foreach (PhotonPlayer player in PhotonNetwork.playerList)
        {
            Score.Add(player.name, 0f);
        }

        snkHead.transform.SetParent(imageTarget.transform, false);
        SnakeMove move = snkHead.GetComponent<SnakeMove>();
        move.boundingBoxCenter = GameObject.Find("BoundingBoxCenter");
        move.ARPlane = GameObject.Find("ARPlane");
    }

    public void SnakeDead()
    {
        Score.Remove(playerName);
        PhotonNetwork.LeaveRoom();
    }

    void OnLeftRoom()
    {
        startButton.gameObject.SetActive(true);
        nameInput.gameObject.SetActive(true);
        startButton.onClick.AddListener(JoinRoom);
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
    public void updateScore (float score)
    {
        if (PhotonNetwork.isMasterClient)
            Score[playerName] = score;
        else 
            photonView.RPC("updateMasterScore", PhotonTargets.MasterClient, score, playerName);
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
