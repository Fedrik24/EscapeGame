using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    ParticleSystem part;
    public GameObject Player;
    public int itemValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        part.Play();

    }

    void Update()
    {
        float Distance = Vector3.Distance(gameObject.transform.position,Player.transform.position);
        float maxDistance = 3f;
        bool isNear = Distance <= maxDistance;


        if (Input.GetKeyUp(KeyCode.F) && isNear)
        {
            gameObject.SetActive(false);
            Score.instace.TambahScore(itemValue);
        }

    }

}
