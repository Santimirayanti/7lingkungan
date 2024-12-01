using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float xSpeed;
    public float jumpForce;
    public float gravity;
    public bool isStart;

    void Start()
    {
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == true)
        {
            rb.velocity = new Vector3(xSpeed, rb.velocity.y - gravity, rb.velocity.z);
            rb.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 5f);
        }
        
    
        if (Input.GetKeyDown(KeyCode.E))
        {
            isStart = true;
            rb.useGravity = true;
            
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
}