using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float movementSpeed;
    public Rigidbody2D rb;

    public Animator anim;

    public float jumpForce;

    public Transform  feet;
    public LayerMask groundLayers;

    float movementx;

    private void Update(){
        movementx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded()){
            Jump();
        }

        if (Mathf.Abs(movementx) > 0.05f)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        if (movementx > 0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (movementx <0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        anim.SetBool("isGrounded", isGrounded());
    }

    private void FixedUpdate(){
        Vector2 movement = new Vector2(movementx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

    public bool isGrounded(){
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }

}
