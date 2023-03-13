using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerManeger : MonoBehaviour
{
    public AkAudioListener cameraListener;
    private List<AkAudioListener> otherListeners;

    void Awake()
    {
        // Get the listener attached to the CameraBrain GameObject
        cameraListener = Camera.main.GetComponentInChildren<AkAudioListener>();

        // Get all other AkListeners in the scene
        otherListeners = new List<AkAudioListener>(FindObjectsOfType<AkAudioListener>());

        // Disable all other listeners except for the one attached to the CameraBrain
        foreach (AkAudioListener listener in otherListeners)
        {
            if (listener != cameraListener)
            {
                listener.enabled = false;
            }
        }
    }
}