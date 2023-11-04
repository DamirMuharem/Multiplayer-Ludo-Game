using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerIV_Script : MonoBehaviour
{
    public static string yellowPlayerIV_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerIV_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerFourColName " + yellowPlayerIV_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerIV_ColName = "none";
    }
}
