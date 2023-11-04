using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerI_Script : ThreeDManager
{
    public static string redPlayerI_ColName;
   
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("After Trigger");
        if (col.gameObject.tag == "Blocks")
        {
            redPlayerI_ColName = col.gameObject.name;

            if (col.gameObject.name.Contains("Red_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        redPlayerI_ColName = "none";
    }

    void OnMouseButton()
    {
        CanMove = true;
       // ThreeDManager.redPlayerI_UI();
    }

}



