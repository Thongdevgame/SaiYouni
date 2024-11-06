using UnityEngine;
using System.Collections.Generic;

public class EnemyMovingRandom : EnemyAbstract
{
    [SerializeField] protected float movementRadius = 20f;
    [SerializeField] protected float pointDistanceLimit = 1f;
    [SerializeField] protected bool isMoving = false;

    void FixedUpdate()
    {
        this.Moving();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        // Ensure ctrl.Agent and ctrl.Animator are loaded here if needed
    }

    protected virtual void Moving()
    {
        this.LoadMovingStatus();

        if (!this.isMoving)
        {
            this.GetRandomPoint();
            this.isMoving = true;
        }

        if (this.isMoving)
        {
            float distanceToTarget = Vector3.Distance(transform.position, this.ctrl.Agent.destination);

            // Stop moving if the enemy reaches close enough to the target
            if (distanceToTarget < this.pointDistanceLimit)
            {
                this.isMoving = false;
                this.ctrl.Agent.isStopped = true; // Stop the agent
            }
        }
    }

    protected virtual void GetRandomPoint()
    {
        Vector3 randomDirection = Random.insideUnitSphere * movementRadius;
        randomDirection += transform.position;

        // Ensure the y position matches the current position to avoid vertical movement
        randomDirection.y = transform.position.y;

        UnityEngine.AI.NavMeshHit hit;

        // Find a point on the NavMesh within movementRadius
        if (UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, movementRadius, 1))
        {
            this.ctrl.Agent.isStopped = false; // Start moving
            this.ctrl.Agent.SetDestination(hit.position);
        }
    }

    protected virtual void LoadMovingStatus()
    {
        this.isMoving = !this.ctrl.Agent.isStopped; // Update moving status based on agent's stopped status

        // Ensure "isMoving" parameter exists in the Animator controller
        if (this.ctrl.Animator != null)
        {
            this.ctrl.Animator.SetBool("isMoving", this.isMoving);
        }
    }
}
