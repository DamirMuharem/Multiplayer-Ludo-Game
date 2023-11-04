using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
//using UnityEditor;

public class MainMenuScript : MonoBehaviour
{
   
    public static int howManyPlayers;
    public GameObject FivePopUp;
    public GameObject LudoPopUp;

    public void TwoPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 2;
        SceneManager.LoadScene("LUDO");
    }
    public void ThreePlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 3;
        SceneManager.LoadScene("LUDO");
    }
    public void FourPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 4;
        SceneManager.LoadScene("LUDO");
    }

    //=================================================================================Ludo Multiplayer
    public void TwoPlayerMultiplayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 2;
        LudoPopUp.SetActive(false);
    }  
    public void ThreePlayerMultiplayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 3;
        LudoPopUp.SetActive(false);
    }
    public void FourPlayerMultiplayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 4;
        LudoPopUp.SetActive(false);
    }

    //=================================================================================Five Player modes
    public void FiveTwoPlayer()
    {
        //SoundManagerScript.buttonAudioSource.Play();
        howManyPlayers = 2;
        SceneManager.LoadScene("3D");
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
