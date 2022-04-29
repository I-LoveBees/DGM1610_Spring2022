using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [Header("Enemy Health")]
    public int curHP; //current HP
    public int maxHP;

    [Header("Enemy Attack")]
    public int damage;
    public float attackRate;
    public float attackRange;
    private float lastAttackTime;
    public PlayerController player;

    [Header("Loot")]
    public GameObject lootDrop;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
        {
            Death();
            LootDrop();
        }
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    void LootDrop()
    {
        Instantiate(lootDrop, transform.position, Quaternion.identity);
    }
}
