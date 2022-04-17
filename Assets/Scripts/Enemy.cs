using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;

    EnemyAI enemyai;

    void Start()
    {
        enemyai = GetComponent<EnemyAI>(); 
    }


    public void Damage(bool hasaralindi)
    {
        

        if (hasaralindi)
        {
           
            
            Die();
        }
    }

    public void Die()
    {
        
        animator.SetBool("Isheart", true);
        enemyai.followspeed = 0;
        Destroy(this.gameObject,0.5f);   

    }
}
