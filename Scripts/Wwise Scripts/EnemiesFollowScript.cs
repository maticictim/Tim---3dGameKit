using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesFollowScript : MonoBehaviour
{
    public GameObject chomper;
    public float followSpeed = 1f;

    void Update()
    {
        if (chomper != null)
        {
            transform.position = Vector3.Lerp(transform.position, chomper.transform.position, followSpeed * Time.deltaTime);
            transform.LookAt(chomper.transform);
        }
    }
}