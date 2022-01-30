using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector3.Distance(gameObject.transform.position, Player.transform.position);
        float maxDistance = 1f;
        bool isNear = Distance <= maxDistance;

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Forest");
        }

    }
}
