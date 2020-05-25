using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMovement : MonoBehaviour
{
    public NavMeshAgent Agent;

    public CapsuleCollider Collider;

    public Transform Player;

    public bool isDead = false;
    bool inReach = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            Vector3 PlayerPos = Player.transform.position;

            if (!inReach)
            {
                Agent.SetDestination(PlayerPos);
            }
        }
    }

    public void setDead()
    {
        isDead = true;
        GameObject.Destroy(Agent);
        GameObject.Destroy(Collider);
    }

    public void setAttack(bool Attack)
    {
        if (!isDead)
        {
            inReach = Attack;
            Agent.isStopped = Attack;
        }
        
    }
}
