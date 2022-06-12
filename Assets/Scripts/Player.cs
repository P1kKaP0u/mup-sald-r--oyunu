using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    public Animator animator;
    PlayerMovement playermovement;
    public GameObject gameovercancas;


    void Start()
    {
        playermovement = GetComponent<PlayerMovement>();
    }


    public void Damage(bool hasaralindi)
    {
        if (hasaralindi)
        {

            Die();
            gameovercancas.SetActive(true);
        } 
    }

    public void Die()
    {
        animator.SetBool("Isheart", true);
        playermovement.speedAmount = 0;
        Destroy(this.gameObject, 1f);

    }

}
