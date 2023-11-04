using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
//using UnityEditor;

public class ChoseNuberOfPlayersMultiplayer : MonoBehaviour
{
    public static int howManyPlayers;
    public GameObject FivePopUp;
    public GameObject LudoPopUp;

    public void TwoPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 2;
        PhotonNetwork.LoadLevel("Multiplayer_Lobby");
    }
    public void ThreePlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 3;
        PhotonNetwork.LoadLevel("Multiplayer_Lobby");
    }
    public void FourPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 4;
        PhotonNetwork.LoadLevel("Multiplayer_Lobby");       
    }

   
    //=================================================================================Five Player modes
    public void FiveTwoPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 2;
        PhotonNetwork.LoadLevel("LUDO");
    }
    public void FiveThreePlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 3;
        SceneManager.LoadScene("3D");
    }
    public void FiveFourPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 4;
        SceneManager.LoadScene("3D");
    }

   




   /* public void Quit()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        if (EditorApplication.isPlaying == true)
        {
            EditorApplication.isPlaying = false;
        }
    }
   */
}
