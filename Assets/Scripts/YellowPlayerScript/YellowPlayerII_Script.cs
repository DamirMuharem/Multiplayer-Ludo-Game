using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerII_Script : MonoBehaviour
{
    public static string yellowPlayerII_ColName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            yellowPlayerII_ColName = col.gameObject.name;
            Debug.Log("yellowPlayerTwoColName " + yellowPlayerII_ColName);
            if (col.gameObject.name.Contains("Yellow_House_Border"))
            {
                //SoundManager.safeHouseAudioSource.Play();
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        yellowPlayerII_ColName = "none";
    }
}
