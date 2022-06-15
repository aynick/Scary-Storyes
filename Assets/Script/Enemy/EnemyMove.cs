using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    [SerializeField] private float speed;
    [SerializeField] private float jumpheight;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        var player = GameObject.FindObjectOfType<Player>().transform.position;
        if (Vector3.Distance(transform.position,player) > 2f )
        {
            _navMeshAgent.SetDestination(player);
        }

    }

    private void TargetMove(Vector3 targetPos)
    {
        transform.Translate(Vector3.MoveTowards(transform.position,targetPos,speed*Time.fixedDeltaTime));
    }
}
