using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerI_Script : MonoBehaviour
{
    public static string yellowPlayerI_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerI_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerFourColName " + yellowPlayerI_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerI_ColName = "none";
    }
}
