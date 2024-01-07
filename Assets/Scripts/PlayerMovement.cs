using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

    private Animator movement_animator;
    public float Speed = 10;
    public float Move;
    public float Jump;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
     movement_animator = GetComponentInChildren<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        Jump = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Move*Speed, rb.velocity.y);
        movement_animator.SetFloat("Speed",Mathf.Abs(Move));


        // Vector3 movement = new Vector3(Move, 0.0f, Jump);
        // transform.rotation = Quaternion.LookRotation(rb.velocity);
        
        
        // transform.Translate (movement * Speed * Time.deltaTime, Space.World);


    }
}
