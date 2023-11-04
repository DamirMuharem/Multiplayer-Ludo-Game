using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerIV_Script : MonoBehaviour
{
    public static string bluePlayerIV_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            bluePlayerIV_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerFourColName " + bluePlayerIV_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        bluePlayerIV_ColName = "none";
    }
}
