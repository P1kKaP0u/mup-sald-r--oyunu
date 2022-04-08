using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    Rigidbody2D rb;
    Vector3 velocity;
    public Animator animator;

    public float speedAmount = 9f;
    public float jumpAmount = 7f;
    public float downAmount = 4f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {

        //Character Left-Right movement
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Speed" , Mathf.Abs(Input.GetAxis("Horizontal")) );

        //Character Jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Approximately(rb.velocity.y, 0))
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }
        if(animator.GetBool("IsJumping") && Mathf.Approximately(rb.velocity.y, 0))
        {
            animator.SetBool("IsJumping", false);
        }

        //Character Left-Right Rotation
        if (Input.GetAxisRaw("Horizontal") == -1 )
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        //Character Attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsAttack" , true); 
        }
        else
        {   
            animator.SetBool("IsAttack" , false);
        }

        //Character FastFall
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * downAmount, ForceMode2D.Impulse);          
        }
        

             
    }
}
