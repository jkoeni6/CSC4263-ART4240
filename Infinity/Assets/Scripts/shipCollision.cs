using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCollision : MonoBehaviour
{
    private GameObject ship1;
    public static int lives;
    AudioSource audio;

    // Boolean to stop enemy movement when the player loses a life
    public static bool shouldMove = true;

    // Method that gives the ship 3 lives at the start of the game
    void Start()
    {
        ship1 = GameObject.Find("Ship_player");
        lives = 3;
        audio = GetComponent<AudioSource>();
    }

    // Method to take away a life when the ship collides with another object
    void OnTriggerEnter2D(Collider2D other)
    {
        shouldMove = false; // Stopping the enemy movement temporarily when the player loses a life
        GameObject obj = other.transform.gameObject;
        Destroy(obj); // Destroys the object the ship collided with
        lives--; // Subtracts a life when the ship collides with another object
        audio.Play();
        if (lives > 0) // If there are more lives left, keep playing
        {
            if (lives == 2)
            {
                Destroy(GameObject.Find("LifeShip3"));
            }
            else if (lives == 1)
            {
                Destroy(GameObject.Find("LifeShip2"));
            }
            print(lives);

        }
        else // Else, Game Over
        {
            Destroy(GameObject.Find("LifeShip1"));
            Destroy(ship1);
            print(lives);
        }       
    }
}
