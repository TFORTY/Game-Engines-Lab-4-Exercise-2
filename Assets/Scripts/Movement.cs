using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirZ;
    private float jumpspeed;

    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();

        jumpspeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ = Input.GetAxis("Vertical") * movespeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {              
            if (isGrounded)
            {
                rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
                isGrounded = false;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {

        }
       
        if (collision.collider.tag == "Obstacle")
        {
            if (collision.contacts[0].normal.y > 0.5)
            {
                Destroy(collision.collider.gameObject);             
            }
        }

        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}