using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerII_Script : MonoBehaviour
{
    public static string bluePlayerII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            bluePlayerII_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerTwoColName " + bluePlayerII_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        bluePlayerII_ColName = "none";
    }
}
