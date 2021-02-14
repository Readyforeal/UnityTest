using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    public float moveSpeed = 2f;
    public Rigidbody2D rb;
    public Animator anim;
    public Transform sprite;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        anim.SetFloat("speed", movement.sqrMagnitude);

        if (movement.x < -0.01)
        {
            sprite.localScale = new Vector3(1, 1, 1);
        }
        else if(movement.x > 0.01){
            sprite.localScale = new Vector3(-1, 1, 1);
        }
    }

    void FixedUpdate() {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
