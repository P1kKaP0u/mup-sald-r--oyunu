using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;


    void Start()
    {
        
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
        Destroy(this.gameObject,0.7f);
      

    }
}
