using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class MovimentoBarra : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    // public float bounceForce = 10f;

    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        // if(Input.GetKey(KeyCode.RightArrow))
        // {
        //     rb.transform.Translate(speed * Time.deltaTime, 0, 0);
        // }
        // if(Input.GetKey(KeyCode.LeftArrow))
        // {
        //     rb.transform.Translate(-speed * Time.deltaTime, 0, 0);
        // }
    }
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Rasengan"))
    //     {


    //         Vector2 contactPoint = collision.contacts[0].point;
    //         Vector2 platformCenter = GetComponent<Collider2D>().bounds.center;


    //         float hitFactor = (contactPoint.x - platformCenter.x) / (GetComponent<Collider2D>().bounds.size.x / 2);
        
    //                 Rigidbody2D ballRb = collision.gameObject.GetComponent<Rigidbody2D>();
    //         if (ballRb != null)
    //         {
        
    //             Vector2 bounceDirection = new Vector2(hitFactor, 1).normalized; 
    //             ballRb.linearVelocity = bounceDirection * bounceForce; 
    //         }
    //     }
    // }
        void Move()
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            rb.linearVelocity = new Vector2(rb.linearVelocity.y * speed, moveX);
        }
}
