using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCollision : MonoBehaviour
{
    private GameObject ship1;
    private GameObject livesText;
	private GameObject livesDisplay1;
	private GameObject livesDisplay2;
    public static int lives;

    // Boolean to stop enemy movement when the player loses a life
    public static bool shouldMove = true;

    // Method that gives the ship 3 lives at the start of the game
    void Start()
    {
        ship1 = GameObject.Find("Ship_player");
        livesText = GameObject.Find("LivesDisplay");
		livesDisplay1 = GameObject.Find("ShipLifeDisplay1");
		livesDisplay2 = GameObject.Find("ShipLifeDisplay2");
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
			if (lives == 2) 
			{
				Destroy (livesDisplay2);
			} 
			else if (lives == 1) 
			{
				Destroy (livesDisplay1);
			}
            print(lives);
        }
        else // Else, Game Over
        {
            Destroy(ship1);
            print(lives);
        }       
    }
}
