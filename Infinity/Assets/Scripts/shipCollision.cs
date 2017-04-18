﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCollision : MonoBehaviour
{
    private GameObject ship1;
    public static int lives;

    // Boolean to stop enemy movement when the player loses a life
    public static bool shouldMove = true;

    // Method that gives the ship 3 lives at the start of the game
    void Start()
    {
        ship1 = GameObject.Find("Ship_player");
        lives = 3;
    }

    // Method to take away a life when the ship collides with another object
    void OnTriggerEnter2D(Collider2D other)
    {
        shouldMove = false; // Stopping the enemy movement temporarily when the player loses a life
        GameObject obj = other.transform.gameObject;
        Destroy(obj); // Destroys the object the ship collided with
        lives--; // Subtracts a life when the ship collides with another object
        if (lives > 0) // If there are more lives left, keep playing
        {
            print(lives);
        }
        else // Else, Game Over
        {
            Destroy(ship1);
            print(lives);
        }       
    }
}
