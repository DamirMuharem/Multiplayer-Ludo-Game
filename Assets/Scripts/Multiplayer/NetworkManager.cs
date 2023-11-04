using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


public class NetworkManager : MonoBehaviour
{
    public PhotonView photonView;

    private int playerCount;

    public int maxPlayersInLobby;

    private float readyUpPlayers;

    public bool isReady;
    public bool canLoadLevel;

    public static bool playAsRedPlayer;
    public static bool playAsBluePlayer;
    public static bool playAsGreenPlayer;
    public static bool playAsYellowPlayer;

    public bool syncPlayers;

    public GameObject onePlayers;
    public GameObject twoPlayers;
    public GameObject threePlayers;
    public GameObject fourPlayers;

    public GameObject redPlayerButton;
    public GameObject bluePlayerButton;
    public GameObject greenPlayerButton;
    public GameObject yellowPlayerButton;

    public GameObject readyUpButton;
    public GameObject notReadyUpButton;

    public Text roomNameTxt;
    public GameObject canvas;

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    

    void Start()
    {
        
        syncPlayers = true;
        canLoadLevel = true;
        photonView = GetComponent<PhotonView>();
        notReadyUpButton.SetActive(false);
        readyUpButton.SetActive(false);

        playAsRedPlayer = false;
        playAsBluePlayer = false;
        playAsGreenPlayer = false;
        playAsYellowPlayer = false;

        //Display Rooom name on screen
        roomNameTxt.text = CreateRoom.roomName;
    }

    // Update is called once per frame
    void Update()
    {
        playerCount = PhotonNetwork.CurrentRoom.PlayerCount;

        if (playerCount == 1)
        {
            onePlayers.SetActive(true);
            twoPlayers.SetActive(false);
            threePlayers.SetActive(false);
            fourPlayers.SetActive(false);
        }

        if (playerCount == 2)
        {
            onePlayers.SetActive(false);
            twoPlayers.SetActive(true);
            threePlayers.SetActive(false);
            fourPlayers.SetActive(false);
        }
        if (playerCount == 3)
        {
            onePlayers.SetActive(false);
            twoPlayers.SetActive(false);
            threePlayers.SetActive(true);
            fourPlayers.SetActive(false);
        }
        if (playerCount >= 4)
        {
            onePlayers.SetActive(false);
            twoPlayers.SetActive(false);
            threePlayers.SetActive(false);
            fourPlayers.SetActive(true);
        }

        if (MainMenuScript.howManyPlayers != 0)
        {
            if (!syncPlayers)
            {
                if (readyUpPlayers == MainMenuScript.howManyPlayers)
                {
                    LoadLudoLevel();
                }
            }
        }
        switch (MainMenuScript.howManyPlayers)
        {
            case 2:
                if (MainMenuScript.howManyPlayers != 0 && syncPlayers)
                {
                    photonView.RPC("SyncPlayers2", RpcTarget.AllBuffered);                   
                }
                break;

            case 3:
                if (MainMenuScript.howManyPlayers != 0 && syncPlayers)
                {
                    photonView.RPC("SyncPlayers3", RpcTarget.AllBuffered);                  
                }
                break;

            case 4:
                if (MainMenuScript.howManyPlayers != 0 && syncPlayers)
                { 
                    photonView.RPC("SyncPlayers4", RpcTarget.AllBuffered);
                    
                }
                break;

            default:
                Debug.Log("Nothing");
                break;
        }



    }

    [PunRPC]
    public void SyncPlayers2()
    {
        MainMenuScript.howManyPlayers = 2;
        Debug.Log(MainMenuScript.howManyPlayers);
        syncPlayers = false;      
        bluePlayerButton.SetActive(false);
        greenPlayerButton.SetActive(false);       
    }

    [PunRPC]
    public void SyncPlayers3()
    {
        MainMenuScript.howManyPlayers = 3;
        Debug.Log(MainMenuScript.howManyPlayers);
        syncPlayers = false;
        greenPlayerButton.SetActive(false);
    }

    [PunRPC]
    public void SyncPlayers4()
    {
        MainMenuScript.howManyPlayers = 4;
        Debug.Log(MainMenuScript.howManyPlayers);
        syncPlayers = false;
    }

    public void LoadLudoLevel()
    {
        if (canLoadLevel)
        {
            PhotonNetwork.LoadLevel("LUDO_Multiplayer");
            canLoadLevel = false;
        }
    }

    public void ReadyUpButtom()
    {
        //photonView.RPC("ReadyUp", RpcTarget.All);
        notReadyUpButton.SetActive(true);
      //  isReady = true;
        Debug.Log(readyUpPlayers);
        readyUpButton.SetActive(false);
        photonView.RPC("ReadyUp", RpcTarget.All);
    }

    public void NotReadyUpButtom()
    {
       // photonView.RPC("NotReadyUo", RpcTarget.All);
        readyUpButton.SetActive(true);
       // isReady = false;
        Debug.Log(readyUpPlayers);
        notReadyUpButton.SetActive(false);
        photonView.RPC("NotReadyUp", RpcTarget.All);
    }

    [PunRPC]
    public void ReadyUp()
    {
        readyUpPlayers = readyUpPlayers + 1f;
    }

    [PunRPC]
    public void NotReadyUp()
    {
        readyUpPlayers = readyUpPlayers - 1f;
    }

    public void RedPlayerButton()
    {
        playAsRedPlayer = true;
        bluePlayerButton.GetComponent<Button>().interactable = false;
        greenPlayerButton.GetComponent<Button>().interactable = false;
        yellowPlayerButton.GetComponent<Button>().interactable = false;
        readyUpButton.SetActive(true);
        photonView.RPC("RedPlayer", RpcTarget.AllBuffered);
    }

    [PunRPC]
    public void RedPlayer()
    {
        redPlayerButton.SetActive(false);
    }

    public void BluePlayerButton()
    {
        playAsBluePlayer = true;
        redPlayerButton.GetComponent<Button>().interactable = false;
        greenPlayerButton.GetComponent<Button>().interactable = false;
        yellowPlayerButton.GetComponent<Button>().interactable = false;
        readyUpButton.SetActive(true);
        photonView.RPC("BluePlayer", RpcTarget.AllBuffered);
    }

    [PunRPC]
    public void BluePlayer()
    {
        bluePlayerButton.SetActive(false);
    }

    public void GreenPlayerButton()
    {
        playAsGreenPlayer = true;
        redPlayerButton.GetComponent<Button>().interactable = false;
        bluePlayerButton.GetComponent<Button>().interactable = false;
        yellowPlayerButton.GetComponent<Button>().interactable = false;
        readyUpButton.SetActive(true);
        photonView.RPC("GreenPlayer", RpcTarget.AllBuffered);
    }

    [PunRPC]
    public void GreenPlayer()
    {
        greenPlayerButton.SetActive(false);
    }

    public void YellowPlayerButton()
    {
        playAsYellowPlayer = true;
        redPlayerButton.GetComponent<Button>().interactable = false;
        bluePlayerButton.GetComponent<Button>().interactable = false;
        greenPlayerButton.GetComponent<Button>().interactable = false;
        readyUpButton.SetActive(true);
        photonView.RPC("YellowPlayer", RpcTarget.AllBuffered);
    }

    [PunRPC]
    public void YellowPlayer()
    {
        yellowPlayerButton.SetActive(false);
    }

}
