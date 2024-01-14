using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;



public class PlayerMovement : MonoBehaviour
{

    private Animator movement_animator;
    public float Speed = 10;
    private Rigidbody2D rb;

    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
     movement_animator = GetComponentInChildren<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        //rb.velocity = new Vector2(movement.x*Speed, movement.y*Speed);
        movement_animator.SetFloat("Speed",movement.sqrMagnitude);
        movement_animator.SetFloat("Horizontal",movement.x);
        movement_animator.SetFloat("Vertical",movement.y);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }

}
