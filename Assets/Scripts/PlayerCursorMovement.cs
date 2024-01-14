using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;



public class PlayerCursorMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    Vector2 mousePos;
    public float Speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    
    void FixedUpdate()
    {
        //Move based on Keyboard inputs
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);

        //Control Player direction based on Mouse direction
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }



}
