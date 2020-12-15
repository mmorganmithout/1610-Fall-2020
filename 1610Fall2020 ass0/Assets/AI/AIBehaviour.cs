﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    private bool canPatrol = true;
    private int i = 0;

    public List<Transform> patrolPoints;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canPatrol = false;
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        canPatrol = true;
    }

    private void Update()
    {
        agent.destination = destination.position;
        if (!canPatrol) return;

        destination = patrolPoints[i];
    }
}