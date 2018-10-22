using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour
{

    public float speed = 4f;

    
    Rigidbody2D rb2d;
    Vector2 mov;  // Ahora es visible entre los métodos



    public static Vector3 mousePosition;




    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();

        
    }

    void Update()
    {

        
        mov = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        FaceMouse();
        
    }

    void FixedUpdate()
    {
        
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }

    void FaceMouse()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(transform.position.x - mousePosition.x, transform.position.y - mousePosition.y);
        transform.up = direction;
    }

}