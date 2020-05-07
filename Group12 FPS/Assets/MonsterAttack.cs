using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonoBehaviour
{
    public Transform ReachCheck;
    public float Reach = 2.5f;
    public LayerMask PlayerMask;

    bool inReach;

    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inReach = Physics.CheckSphere(ReachCheck.position, Reach, PlayerMask);

        Anim.SetBool("InReach", inReach);
    }
}
