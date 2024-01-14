using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;



public class PlayerCursorMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
    }

    private void LookAtMouse(){
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos.x);
        Debug.Log(mousePos.y);
        transform.up = (Vector3)(mousePos - new Vector2 (transform.position.x, transform.position.y));
    }

}
