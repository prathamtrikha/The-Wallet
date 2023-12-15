using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour {
	//EnemyPatrol WayPoints
	public Transform[] patrolPoints;
	public float chaseDistance = 11f;

	//Enemy NavMesh Agent
	private NavMeshAgent agent;
	public Transform player;
	private int currentPatrolIndex = 0;
	private bool isChasing = false;


	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag("Player").transform;

		if (patrolPoints.Length > 0)
		{
			SetDestination(patrolPoints[currentPatrolIndex].position);
		}
	}

	private void Update()
	{	
		//Checking whether Player is present or not
		if (player != null)
		{	
			//Calculate Distance between Enemy and Player
			float distanceToPlayer = Vector3.Distance(transform.position, player.position);


			//activate Chasing to Player
			if (distanceToPlayer <= chaseDistance)
			{
				isChasing = true;
				agent.speed = 1.5f;
				SetDestination(player.position);
			}
			//Deactivate CHasing to Player
			else if (isChasing && distanceToPlayer > chaseDistance)
			{
				isChasing = false;
				SetDestination(patrolPoints[currentPatrolIndex].position);
			}
		}

		//if Ennemy isnt Chasing and Calculating path Chasing become Deactivate
		if (!agent.pathPending && agent.remainingDistance < 0.5f)
		{
			if (!isChasing)
			{
				SetNextPatrolPoint();
			}
		}
	}

	//For Setting WayPoint
	private void SetDestination(Vector3 destination)
	{
		agent.SetDestination(destination);
	}


	//for assigning a NewPatrolPoint
	private void SetNextPatrolPoint()
	{
		currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
		SetDestination(patrolPoints[currentPatrolIndex].position);
	}
}
