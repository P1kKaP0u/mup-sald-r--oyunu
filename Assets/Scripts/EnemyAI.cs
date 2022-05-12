using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Animator animator;
    public Vector2 pos1;
    public Vector2 pos2;
    public float speed;
    private float oldPosition;
    public float distance;
    private Transform target;
    public float followspeed;
    private bool enemyTrigger;

    EnemyAttack enemyattack;
    

    void Start()
    {
        Physics2D.queriesStartInColliders = false;

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animator = GetComponent<Animator>();

        enemyattack = GetComponent<EnemyAttack>();

          
    }


    void Update()
    {

        EnemyAi();

    }



    void EnemyMove()
    {

        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
       
        

        if (transform.position.x<oldPosition)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (transform.position.x>oldPosition)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        oldPosition = transform.position.x;



    }


    void EnemyAi()
    {

        RaycastHit2D hitEnemy = Physics2D.Raycast(transform.position, transform.right, distance);

        
        if (hitEnemy.collider == null )
        {
           
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
            animator.SetBool("Attack", false);
            
            if (enemyTrigger)
            {
                EnemyFollow(followspeed = 4f);
            }
            else
            {
                EnemyMove();
            }

        }
        else
        {
            enemyTrigger = true;

            Debug.DrawLine(transform.position, hitEnemy.point, Color.red);
            EnemyFollow(followspeed = 4f);



            if (transform.position.x - GameObject.Find("Player").GetComponent<Transform>().position.x < 3f)
            {
                animator.SetBool("Attack", true);

                enemyattack.DamagePlayer();
            }

        }
    }
        


    void EnemyFollow(float followspeed)
    {



        Vector3 targetPosition = new Vector3(target.position.x, gameObject.transform.position.y, target.position.x);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, followspeed * Time.deltaTime);

        
        
    }

}
