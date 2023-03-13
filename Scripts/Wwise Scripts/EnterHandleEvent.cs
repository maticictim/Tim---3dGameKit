using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHandleEvent : MonoBehaviour
{

    public AkEvent starship_end;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            starship_end.HandleEvent(gameObject);
        }
}
}