using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    public byte maxPlayersInRoom;

    //public InputField roomName;

    public static string roomName;

    public GameObject LudoPopUp;


    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    private void Start()
    {
        CreateRandomName();
        LudoPopUp.SetActive(true);
    }
    void Update()
    {
        maxPlayersInRoom = System.Convert.ToByte(MainMenuScript.howManyPlayers);
    }

    public void CreateRoomInput()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = maxPlayersInRoom;// for example
        PhotonNetwork.CreateRoom(roomName, roomOptions, null);
        PhotonNetwork.LoadLevel("Multiplayer_Lobby");
    }

    //public override void OnJoinedRoom()
    //{
    //     PhotonNetwork.LoadLevel("Ludo_challenge_pop_up");
    // }

    public void CreateRandomName()
    {
        //string name = "";

        for (int counter = 1; counter <= 6; ++counter)
        {
            bool upperCase = true;

            int rand = 0;
            if (upperCase)
            {
                rand = Random.Range(65, 91);
            }

            roomName += (char)rand;
        }

        Debug.Log(roomName);
    }

}
