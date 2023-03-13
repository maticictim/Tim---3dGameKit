using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSoundsOnDestroy : MonoBehaviour
{
    private AkAmbient StopAllSounds;

    private void Start()
    {
        StopAllSounds = GetComponent<AkAmbient>();
    }

    private void OnDestroy()
    {
        if (StopAllSounds != null)
        {
            AkSoundEngine.StopAll(StopAllSounds.gameObject);
        }
    }
}
