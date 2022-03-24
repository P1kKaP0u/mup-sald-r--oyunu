using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    Rigidbody2D rb;
    Vector3 velocity;

    float speedAmount = 7f;
    float jumpAmount = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow) && Mathf.Approximately(rb.velocity.y, 0))
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        }

        if (Input.GetAxisRaw("Horizontal") == -1 )
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
 
    }
}
