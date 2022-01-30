using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        float maxDistance = 10f;
        bool isNear = distance <= maxDistance;

        if (isNear != true)
        {
            gameObject.SetActive(false);
        }
        else if (isNear != false)
        {
            gameObject.SetActive(true);
        }
    }
}
