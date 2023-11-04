using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerIII_Script : MonoBehaviour
{
    public static string bluePlayerIII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            bluePlayerIII_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerThreeColName " + bluePlayerIII_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        bluePlayerIII_ColName = "none";
    }
}
