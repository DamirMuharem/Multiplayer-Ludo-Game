using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ludo : MonoBehaviour
{
    
    public GameObject LudoPopUp;

    public void LudoPopUpMethod()
    {
        LudoPopUp.SetActive(true);
    }
    public void CloseMethod()
    {
        SceneManager.LoadScene("Ludo_Challenge");
    }
    public void HomeMethod()
    {
        SceneManager.LoadScene("Homepage_Updated");
    }

    public void OnlineLoading()
    {
        SceneManager.LoadScene("Load_Scene_Online");
    }

    public void CreateRoomMethod()
    {
        SceneManager.LoadScene("Load_Scene_Create_Room");
    }

}
