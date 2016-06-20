using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : Photon.MonoBehaviour {

    public Button startButton;
    public Button resetButton;
    public InputField nameInput; 
    public Text[] rankTexts;
    public Text connectionFail;
    public Canvas ui;

    private GameObject imageTarget;

    private string errorMessage;
    private string playerName;
    private float spawnTimer;

    private Hashtable Score;
    private string first;
    private string second;
    private string third;
    private float firstScore;
    private float secondScore;
    private float thirdScore;

    void Start()
    {
        foreach(Text text in rankTexts){
            text.gameObject.SetActive(false);
        }
        connectionFail.gameObject.SetActive(true);
        PhotonNetwork.ConnectUsingSettings("1.7");
        imageTarget = GameObject.Find("ImageTarget");
        resetButton.enabled = true;
        resetButton.onClick.AddListener(Start);
        Score = new Hashtable();
    }

    void OnFailedToConnectToPhoton(){

        Debug.Log("On Failure");
        PhotonNetwork.Disconnect();

    }

    void FixedUpdate()
    {
        if (PhotonNetwork.isMasterClient) {
            updateRank();
            if (first != null)
                firstScore = (float)Score[first];
            if (second != null)
                secondScore = (float)Score[second];
            if (third != null)
                thirdScore = (float)Score[third];
        }
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
        if (first == null)
            rankTexts[0].text = "";
        else
            rankTexts[0].text = "#1  " + first + " " + firstScore;
        if (second == null)
            rankTexts[1].text = "";
        else
            rankTexts[1].text = "#2  " + second + " " + secondScore;
        if (third == null)
            rankTexts[2].text = "";
        else
            rankTexts[2].text = "#3  " + third + " " + thirdScore;
    }

    void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby");
        startButton.onClick.AddListener(JoinRoom);
        connectionFail.gameObject.SetActive(false);
    }

    void JoinRoom()
    {
        Debug.Log("JoinRoom");
        if(nameInput.text.Length > 0)
        {
            RoomOptions roomOptions = new RoomOptions()
            {
                isVisible = false,
                maxPlayers = 20
            };
            PhotonNetwork.JoinOrCreateRoom("master", roomOptions, TypedLobby.Default);
        }
        startButton.gameObject.SetActive(false);
        nameInput.gameObject.SetActive(false);
        resetButton.gameObject.SetActive(false);
        foreach(Text text in rankTexts){
            text.gameObject.SetActive(true);
        }

    }

    void OnJoinedRoom()
    {
        Debug.Log("OnJoinRoom");
        GameObject snkHead = PhotonNetwork.Instantiate( "SnakeHead", imageTarget.transform.position, imageTarget.transform.rotation, 0); 
        SnakeMove me = snkHead.GetComponent<SnakeMove>();
        playerName = nameInput.text;
        PhotonNetwork.playerName = playerName;
        me.NM = GameObject.Find("GameManager").GetComponent<NetworkManager>();
        //Score = new Hashtable();
        //if (PhotonNetwork.isMasterClient) {
            foreach (PhotonPlayer player in PhotonNetwork.playerList)
            {
                Score.Add(player.name, 0f);
            }
        //}

        snkHead.transform.SetParent(imageTarget.transform, false);
        SnakeMove move = snkHead.GetComponent<SnakeMove>();
        move.boundingBoxCenter = GameObject.Find("BoundingBoxCenter");
        move.ARPlane = GameObject.Find("ARPlane");
        //startButton.gameObject.SetActive(false);
        //nameInput.gameObject.SetActive(false);
    }

    /*public void SnakeDead()
    {
        Score.Remove(playerName);
        PhotonNetwork.LeaveRoom();
    }*/

    void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
    {
        if(PhotonNetwork.isMasterClient) {
            PhotonNetwork.DestroyPlayerObjects(otherPlayer);
            Score.Remove(playerName);
        }
    }

    public void SnakeDead()
    {
        Debug.Log("blah");
        Score.Remove(playerName);
        Debug.Log("blah");
        updateRank();
        Debug.Log("blah");
        if (PhotonNetwork.isMasterClient) {
            PhotonNetwork.SetMasterClient(PhotonNetwork.otherPlayers[0]);
            foreach (string name in Score.Keys )
                photonView.RPC("passScore", PhotonTargets.MasterClient, (float)Score[name], name);
            //PhotonNetwork.DestroyPlayerObjects(PhotonNetwork.player);
        }
        Debug.Log("blah");
        foreach(Text text in rankTexts){
            text.gameObject.SetActive(false);
        }
        PhotonNetwork.LeaveRoom();
    }

    [PunRPC]
    void passScore (float score, string name)
    {
        /*if (Score.ContainsKey(name))
            Score[name] = score;
        else
            Score.Add(name, score);*/
        Score.Add(name, score);
    }

    void OnLeftRoom()
    {
        Debug.Log("OnLeftRoom");
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
        /*if (Score.ContainsKey(name))
            Score[name] = score;
        else
            Score.Add(name, score);*/
        Score[name] = score;
    }
    
    private void updateRank()
    {
        List<string> ranking = new List<string>();
        foreach (string name in Score.Keys)
        {
            float playerScore = (float)Score[name];
            int idx = 0;
            for (; idx < ranking.Count; idx++)
            {
                if ((float)Score[ranking[idx]] < playerScore)
                    break;
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
        //Debug.Log("GGGGGGGGGGGGGGGGGGGGGGGG");
        if (stream.isWriting)
        {
            stream.SendNext(first);
            stream.SendNext(second);
            stream.SendNext(third);
            stream.SendNext(firstScore);
            stream.SendNext(secondScore);
            stream.SendNext(thirdScore);
        }
        else
        {
            first = (string)stream.ReceiveNext();
            second = (string)stream.ReceiveNext();
            third = (string)stream.ReceiveNext();
            firstScore = (float)stream.ReceiveNext();
            secondScore = (float)stream.ReceiveNext();
            thirdScore = (float)stream.ReceiveNext();
            //Debug.Log(first);
        }
    }
}
