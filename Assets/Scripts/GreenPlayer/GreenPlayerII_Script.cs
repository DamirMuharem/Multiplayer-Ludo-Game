using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerII_Script : MonoBehaviour
{
    public static string greenPlayerII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerII_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerTwoColName " + greenPlayerII_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerII_ColName = "none";
    }
}
