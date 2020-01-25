using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{
    public bool active = false;

    /// <summary>
    /// If active print the players name
    /// </summary>
    void Update()
    {
        if(active)
        {
            print(name);
        }
    }

    /// <summary>
    /// Turns the player on or off
    /// Must be a public function
    /// </summary>
    public void toggleActive()
    {
        if(active)
        {
            active = false;
        }
        else
        {
            active = true;
        }
    }
}
