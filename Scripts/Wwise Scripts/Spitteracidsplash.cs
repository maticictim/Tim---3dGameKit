using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitteracidsplash : MonoBehaviour
{

    public AK.Wwise.Event spitter_acid;

   public void acidsplash ()
    {
        spitter_acid.Post(gameObject);
    }
}
