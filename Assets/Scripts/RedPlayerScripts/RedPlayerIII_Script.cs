using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerIII_Script : MonoBehaviour
{

    public static string redPlayerIII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            redPlayerIII_ColName = col.gameObject.name;

            if (col.gameObject.name.Contains("Red_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        redPlayerIII_ColName = "none";
    }
}
