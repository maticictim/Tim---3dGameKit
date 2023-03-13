using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperSwitch : MonoBehaviour
{
    public string SwitchGroup = "Ground_Material";
    private string currentSurface = "Mud";
    public GameObject Chomper;

    private void Update()
    {
        // Check if the character is walking on a different surface
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (currentSurface == "Grass")
            {
                currentSurface = "Mud";
            }
            else if (currentSurface == "Mud")
            {
                currentSurface = "Stone";
            }
            else if (currentSurface == "Stone")
            {
                currentSurface = "Gravel";
            }
            else if (currentSurface == "Gravel")
            {
                currentSurface = "Water";
            }
            else
            {
                currentSurface = "Grass";
            }

            // Trigger the appropriate switch based on the current surface
            AkSoundEngine.SetSwitch("Chomper_walk_switch", currentSurface, gameObject);
        }
    }
}




