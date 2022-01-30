using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent Mob;
    public GameObject Player;
    public float mobDistance = 4.0f;
    private Animator anim;
    public Renderer rend;
    public AudioSource enemychase;


    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        float maxDistance = 10f;
        bool isNear = distance <= maxDistance;

        if (distance < mobDistance)
        {
            rend.enabled = true;
            enemychase.Play();

            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            anim.SetTrigger("Walk");
            Mob.SetDestination(newPos);
        }
        if(isNear == false)
        {
            rend.enabled = false;
        }
    }
}
