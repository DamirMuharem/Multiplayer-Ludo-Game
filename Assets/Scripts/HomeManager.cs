using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HomeManager : MonoBehaviour
{
  
    //Home Page
    public GameObject ProfilePopUp;
   
    public void ProfileMethod()
    {
        ProfilePopUp.SetActive(true);
    }

    

    public void SevenChall()
    {
        SceneManager.LoadScene("7_cross_7");
    }

    public void FiveChall()
    {
        SceneManager.LoadScene("5_cross_5");
    }

    public void Ludo()
    {
        SceneManager.LoadScene("Ludo_Challenge");
    }
     public void Back()
    {
        SceneManager.LoadScene("Homepage_Updated");
    }



}
