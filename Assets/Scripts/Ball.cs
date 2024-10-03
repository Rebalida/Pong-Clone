using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 5f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent <Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set up the initial direction for the ball (left or right)
        float randomDirection = Random.Range(0, 2);

        Debug.Log(randomDirection);

        // Decide the x direction based on the random value
        float xDirection;
        if (randomDirection == 0)
        {
            xDirection = -1f;
        }
        else
        {
            xDirection = 1f;
        }

        // xDirection * ballSpeed = control how fast the ball moves in that direction.
        rb.velocity = new Vector2(xDirection * ballSpeed, Random.Range(-1f, 1f) * ballSpeed);//Random.Range can also be a y.Direction
    }

    private void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        //Check if the tag is = Paddle then print a text
        if (other.gameObject.CompareTag("Paddle"))
        {

            Debug.Log("Paddle Hit");
        }
        //Check if the tag is = Wall then print a text
        else if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Wall Hit");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            Debug.Log("Player Scored");
        }
    }
}
