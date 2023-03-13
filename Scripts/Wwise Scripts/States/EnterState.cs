using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnterState : MonoBehaviour
{
    public string footstepEnter; // This is the name of the state you want to set, such as "Concrete" or "Gravel"


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AkSoundEngine.SetState("FootstepTypes", footstepEnter);
        }
    }
}