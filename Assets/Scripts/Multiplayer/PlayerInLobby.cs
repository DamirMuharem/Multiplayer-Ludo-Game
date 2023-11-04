using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerInLobby : MonoBehaviour
{
    PhotonView photonView;

    private float readyUpPlayers;

    private bool isReady;


    public GameObject readyUpButton;
    public GameObject notReadyUpButton;

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        readyUpButton.SetActive(true);
        notReadyUpButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [PunRPC]
    public void ReadyUpButton()
    {
        photonView.RPC("ReadyUp", RpcTarget.All);
    }

    [PunRPC]
    public void NotReadyUpButton()
    {
        photonView.RPC("NotReadyUp", RpcTarget.All);
    }
    [PunRPC]
    public void ReadyUp()
    {
         notReadyUpButton.SetActive(true);
         isReady = true;
         readyUpPlayers = readyUpPlayers + 1f;
         Debug.Log(readyUpPlayers);
         readyUpButton.SetActive(false);
    }
    [PunRPC]
    public void NotReadyUp()
    {
        readyUpButton.SetActive(true);
        isReady = false;
        readyUpPlayers = readyUpPlayers - 1f;
        Debug.Log(readyUpPlayers);
        notReadyUpButton.SetActive(false);
    }
}
