using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampu : MonoBehaviour
{
    Light lampu;
    public GameObject Player;

    void Start()
    {
        lampu = GetComponent<Light> ();
    }

    void Update()
    {
        float Distance = Vector3.Distance(gameObject.transform.position, Player.transform.position);
        float maxDistance = 3f;
        bool isNear = Distance <= maxDistance;

        if (Input.GetKeyUp(KeyCode.E) && isNear )
        {
            lampu.enabled = !lampu.enabled;
        }
    }

}
