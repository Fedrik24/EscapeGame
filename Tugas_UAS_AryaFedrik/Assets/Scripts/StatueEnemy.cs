using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StatueEnemy : MonoBehaviour
{
    public GameObject target;
    public GameObject Player;
    public Camera cam;
    private NavMeshAgent Mob;


    public float mobDistance = 10f;

    private void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
    }

    private bool IsVisible(Camera c, GameObject target)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(c);
        var point = target.transform.position;

        foreach(var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
            {
                return false;
            }

        }
        return true;
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        float maxDistance = 10f;
        bool isNear = distance <= maxDistance;


        if (IsVisible(cam, target))
        {
            gameObject.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
        }
        else if (distance < mobDistance)
        {
            gameObject.GetComponent<NavMeshAgent>().speed = 3.5f;
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            Mob.SetDestination(newPos);
        }
    }

}
