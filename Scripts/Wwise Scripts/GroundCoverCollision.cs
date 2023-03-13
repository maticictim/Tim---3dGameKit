using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCoverCollision : MonoBehaviour
{
    public AkEvent GroundCover;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GroundCover.HandleEvent(gameObject);
        }
}
}