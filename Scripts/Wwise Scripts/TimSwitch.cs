using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimSwitch : MonoBehaviour
{
    // The name of the Switch Group to set when the player enters the trigger
    public string switchGroupName = "GroundSurface";

    // The name of the Switch to set when the player enters the trigger
    public string switchName = "Earth";

    // The ID of the switch group, initialized at runtime
    private uint switchGroupID;

    private void Awake()
    {
        // Get the switch group ID from the string name
        switchGroupID = AkSoundEngine.GetIDFromString(switchGroupName);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // Get the switch ID from the string name
            uint switchID = AkSoundEngine.GetIDFromString(switchName);

            // Set the Wwise Switch on the player object
            AkSoundEngine.SetSwitch(switchGroupID, switchID, gameObject);


            // Output a message to the console to indicate that the trigger has been entered
            Debug.Log("Player entered trigger: " + this.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Get the switch ID for the default switch ("Stone") from its string name
            uint defaultSwitchID = AkSoundEngine.GetIDFromString("Stone");

            // Set the default switch on the player object
            AkSoundEngine.SetSwitch(switchGroupID, defaultSwitchID, gameObject);
        }
    }
}
