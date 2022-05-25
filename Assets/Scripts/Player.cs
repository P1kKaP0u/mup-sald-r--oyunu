using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Animator animator;

    PlayerMovement playermovement;

    void Start()
    {
        playermovement = GetComponent<PlayerMovement>();
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
        playermovement.speedAmount = 0;
        Destroy(this.gameObject, 1f);

    }

}
