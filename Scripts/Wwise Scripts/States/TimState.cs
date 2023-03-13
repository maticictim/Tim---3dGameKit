using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimState : MonoBehaviour
{
    public string footstepEnter; // This is the name of the state you want to set, such as "Concrete" or "Gravel"
    public string footstepExit;

    private Collider mostRecentCollider; // The most recently entered collider

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (mostRecentCollider != null)
            {
                mostRecentCollider.enabled = false;
            }

            mostRecentCollider = other;
            AkSoundEngine.SetState("FootstepTypes", footstepEnter);
            Debug.Log("Entered " + footstepEnter);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other == mostRecentCollider)
        {
            mostRecentCollider = null;
            AkSoundEngine.SetState("FootstepTypes", footstepExit);
            Debug.Log("Exited " + footstepExit);
        }
    }
}