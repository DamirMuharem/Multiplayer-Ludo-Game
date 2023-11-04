using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Five : MonoBehaviour
{
  
    public GameObject FivePopUp;

    public void FivePopUpMethod()
    {
        FivePopUp.SetActive(true);
    }

    public void CloseMethod()
    {
        SceneManager.LoadScene("5_cross_5");
    }

    public void HomeMethod()
    {
        SceneManager.LoadScene("Homepage_Updated");
    }

    
}
