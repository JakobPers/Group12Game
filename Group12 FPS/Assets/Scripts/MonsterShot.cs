using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShot : MonoBehaviour
{

    public float Health = 100f;

    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        Anim.SetFloat("Health", Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;

        Anim.SetFloat("Health", Health);


    }
}
