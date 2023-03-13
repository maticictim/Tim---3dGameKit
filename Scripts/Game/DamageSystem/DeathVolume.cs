using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    [RequireComponent(typeof(Collider))]
    public class DeathVolume : MonoBehaviour
    {
        public new AK.Wwise.Event audio;
        bool isSoundPlaying;

        void OnTriggerEnter(Collider other)
        {
            var pc = other.GetComponent<PlayerController>();
            if (pc != null)
            {
                pc.Die(new Damageable.DamageMessage());
                
            }
            if (audio != null)
            {
                    audio.Post(gameObject);
            }
        }

        void Reset()
        {
            if (LayerMask.LayerToName(gameObject.layer) == "Default")
                gameObject.layer = LayerMask.NameToLayer("Environment");
            var c = GetComponent<Collider>();
            if (c != null)
                c.isTrigger = true;
        }

    }
}
