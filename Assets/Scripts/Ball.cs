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

    // Update is called once per frame
    void Update()
    {
        
    }
}
