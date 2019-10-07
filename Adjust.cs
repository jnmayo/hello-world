using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adjust : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 300, 140, 30),"Health up"))
        {
            GameControl.control.health += 10;
        }
        if (GUI.Button(new Rect(10, 340, 140, 30), "Health down"))
        {
            GameControl.control.health -= 10;
        }
        if (GUI.Button(new Rect(10, 380, 140, 30), "Experience up"))
        {
            GameControl.control.experience += 10;
        }
        if (GUI.Button(new Rect(10, 420, 140, 30), "Experience down"))
        {
            GameControl.control.experience -= 10;
        }

        if (GUI.Button(new Rect(10, 460, 140, 30), "Save"))
        {
            GameControl.control.Save();
        }
        if (GUI.Button(new Rect(10, 500, 140, 30), "Load"))
        {
            GameControl.control.Load();
        }
    }
}
