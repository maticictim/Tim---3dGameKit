using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class Spit : GrenadierGrenade
    {
        public AkEvent spitter_acid;

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);

            if(explosionTimer < 0)
                Explosion();
            spitter_acid.HandleEvent(gameObject);
        }
    }
}