using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private AudioSource source;
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;
    private bool facingRight = true;
    public Animator animator;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        source = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            source.Play();
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false;
        }
        animator.SetBool("Jumped", !isGrounded);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            isGrounded = true;
            Debug.Log("touching");
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveInput * speed));
        animator.SetFloat("Vel", rb.velocity.y);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            flip();
        }
    }
}