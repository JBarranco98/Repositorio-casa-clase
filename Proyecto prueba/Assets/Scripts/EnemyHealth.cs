using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : Health
{
    private Animator myAnimator;
    private NavMeshAgent agent;
    public float timeToDie = 4;
    private Collider myCollider;

    private void Awake()
    {
        myAnimator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        myCollider = GetComponent<Collider>();
    }

    public override void Die()
    {
        myCollider.enabled = false;
        myAnimator.SetTrigger("Death");
        //agent.speed = 0;
        agent.isStopped = true;
        StartCoroutine(DeathCorrutine());
    }

    public IEnumerator DeathCorrutine()
    {
        yield return new WaitForSeconds(timeToDie);
        Destroy(gameObject);
    }
}