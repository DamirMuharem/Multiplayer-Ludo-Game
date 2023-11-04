using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerI_Script : MonoBehaviour
{
    public static string greenPlayerI_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerI_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerFourColName " + greenPlayerI_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerI_ColName = "none";
    }
}
