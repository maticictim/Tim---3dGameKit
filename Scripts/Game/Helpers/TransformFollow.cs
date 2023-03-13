using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class TransformFollow : MonoBehaviour
{
    public Transform target; // the object to follow
        public float speed = 1.0f; // the speed at which to follow the target

        void Update()
        {
            if (target != null) // check if the target still exists
            {
                // move towards the target's position
                transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
}