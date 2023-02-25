using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemnet : MonoBehaviour
{
    float horizontalInput;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpingForce = 8f;
    bool isFacingRight = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Rigidbody2D rb;

    private void Update()
    {
        flip();
        horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingForce);
        }
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void flip()
    {
        if (isFacingRight == true && horizontalInput < 0f || isFacingRight == false && horizontalInput > 0f)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            isFacingRight = !isFacingRight;
        }
    }
}
