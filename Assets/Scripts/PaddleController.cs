using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public float moveSpeed = 2f; // The speed of the paddle
    public float minY = 1f;  // Bottom boundary
    public float maxY = 9f; // Top boundary


    private void Update()
    {
        // Get input from player (1 for up, -1 for down, 0 for no movement)
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate how much to move this frame (input x speed)
        float moveAmount = verticalInput * moveSpeed * Time.deltaTime; 
        
        //current position
        Vector2 newPosition = transform.position;

        //add the speed x value to the current positon
        newPosition.y += moveAmount;

        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        //set the paddle to a new position
        transform.position = newPosition;
    }


}
