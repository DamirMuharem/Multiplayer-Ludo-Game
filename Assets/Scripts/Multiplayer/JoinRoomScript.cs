using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class JoinRoomScript : MonoBehaviourPunCallbacks
{
    public InputField joinRoomInput;

    public GameObject buttonName;
    public GameObject tabRooms;

    private List<RoomInfo> roomList;

   void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public void JoinRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

   public void JoinRoom()
    {       
        PhotonNetwork.JoinRoom(joinRoomInput.text);
    }

    public void JoinRoomList(Transform p_button)
    {
        string t_roomName = p_button.Find("Name").GetComponent<Text>().text;
        PhotonNetwork.JoinRoom(t_roomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Multiplayer_Lobby");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
        Debug.Log(message);
    }

    public override void OnRoomListUpdate(List<RoomInfo> p_list)
    {
        roomList = p_list;

        Transform content = tabRooms.transform.Find("RoomListScrollBar/Viewport/Content");

        foreach (RoomInfo a in roomList)
        {
            GameObject newButtonRoom = Instantiate(buttonName, content) as GameObject;

            newButtonRoom.transform.Find("Name").GetComponent<Text>().text = a.Name;

            newButtonRoom.GetComponent<Button>().onClick.AddListener(delegate { JoinRoomList(newButtonRoom.transform); });
        }
        base.OnRoomListUpdate(roomList);
    }

}
