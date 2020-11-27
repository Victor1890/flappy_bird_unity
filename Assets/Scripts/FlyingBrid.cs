using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBrid : MonoBehaviour
{
    public float velocity = 1.0f;
    public GameManager gameManager;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
