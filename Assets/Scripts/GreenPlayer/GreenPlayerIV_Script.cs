using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerIV_Script : MonoBehaviour
{
    public static string greenPlayerIV_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerIV_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerFourColName " + greenPlayerIV_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerIV_ColName = "none";
    }
}
