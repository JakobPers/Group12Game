using UnityEngine;

public class MonsterShot : MonoBehaviour
{
    private float Health;

    Animator Anim;

    public MonsterMovement MonsterMove;
    //private Transform Player = GameObject.FindWithTag("Player").transform;

    public Transform ReachCheck;
    public float Reach = 1.7f;
    public LayerMask PlayerMask;

    bool inReach;
    bool isDead;

    float Cooldown;

    float AttackRate = 1f;
    private float AttackDamage = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100f;
        Anim = gameObject.GetComponent<Animator>();
        Anim.SetFloat("Health", Health);
    }

    // Update is called once per frame
    void Update()
    {
        inReach = Physics.CheckSphere(ReachCheck.position, Reach, PlayerMask);

        Anim.SetBool("InReach", inReach);

        MonsterMove.setAttack(inReach);

        if (inReach && !isDead && Time.time >= Cooldown)
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerStats>().TakeDamage(AttackDamage);
            Cooldown = Time.time + 1f / AttackRate;
        }
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;

        Anim.SetFloat("Health", Health);

        if (Health < 1f)
        {
            MonsterMove.setDead();
            isDead = true;
        }
    }
}