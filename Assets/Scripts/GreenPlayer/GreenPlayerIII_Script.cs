using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerIII_Script : MonoBehaviour
{
    public static string greenPlayerIII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            greenPlayerIII_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerThreeColName " + greenPlayerIII_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        greenPlayerIII_ColName = "none";
    }
}
