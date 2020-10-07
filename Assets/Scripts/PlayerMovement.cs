using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce;

    float movementx;

    private void Update(){
        movementx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump")){
            Jump();
        }
    }

    private void FixedUpdate(){
        Vector2 movement = new Vector2(movementx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }
}
