using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private int pontos = 0;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bandana"))
        {
            rb.gravityScale = 0;
        }
        
    }

    public void ontTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        pontos++;
    }

    public int PegaPontos()
    {
        return pontos;
    }
}
