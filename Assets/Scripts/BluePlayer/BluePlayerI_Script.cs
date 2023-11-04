using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerI_Script : MonoBehaviour
{
    public static string bluePlayerI_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            bluePlayerI_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerFourColName " + bluePlayerI_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        bluePlayerI_ColName = "none";
    }
}
