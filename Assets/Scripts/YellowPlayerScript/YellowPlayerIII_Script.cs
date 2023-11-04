using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerIII_Script : MonoBehaviour
{
    public static string yellowPlayerIII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerIII_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerThreeColName " + yellowPlayerIII_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerIII_ColName = "none";
    }
}
