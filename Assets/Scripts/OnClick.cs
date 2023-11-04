using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // this namespace makes the magic, tho

public class OnClick : MonoBehaviour
{
    public bool interactable;
    [SerializeField] UnityEvent anEvent; // puts an easy to setup event in the inspector and anEvent references it so you can .Invoke() it

    // This captures a click as long as you have a collider, even if it's set to just be a trigger, and nothing blocking it.
    // However, it will still capture even if a Gui button is on top of it, so make sure you aren't checking this while also checking Gui
    // Only other colliders block and it's not as manageable as Canvas Groups.

    private void OnMouseDown()
    {
        print("You clicked the cube!");
        interactable = true;
        anEvent.Invoke(); // Triggers the events you have setup in the inspector
    }

    
}