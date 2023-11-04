using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Seven : MonoBehaviour
{
    public static int howManyPlayers;
    public GameObject SevenPopUp;

    public void SevenPopUpMethod()
    {
        SevenPopUp.SetActive(true);
    }
    public void CloseMethod()
    {
        SceneManager.LoadScene("7_cross_7");
    }
     public void HomeMethod()
    {
        SceneManager.LoadScene("Homepage_Updated");
    }
    //Player modes
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

}
