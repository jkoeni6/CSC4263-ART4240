using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCollision : MonoBehaviour
{
    private GameObject ship1;
    private GameObject livesText;
	private GameObject livesDisplay1;
	private GameObject livesDisplay2;
    private GameObject livesDisplay3;
    private GUIText txtRef;
    public static int lives;
    private float timeLeft = 4; // Time in seconds for countdown

    // Boolean to stop enemy movement when the player loses a life
    public static bool shouldMove = true;

    // Boolean to expect SPACE key as input
    private bool expectSpace = false;
     
    // Boolean to start countdown in Update() if the player presses the SPACE key
    private bool startCountdown = false;

    // Method that gives the ship 3 lives at the start of the game
    void Start()
    {
        ship1 = GameObject.Find("Ship_player");
        livesText = GameObject.Find("LivesDisplay");
		livesDisplay1 = GameObject.Find("ShipLifeDisplay1");
		livesDisplay2 = GameObject.Find("ShipLifeDisplay2");
        livesDisplay3 = GameObject.Find("ShipLifeDisplay3");
        txtRef = GameObject.Find("LostLife").GetComponent<GUIText>();
        txtRef.enabled = false;
        lives = 3;
    }

    // Method that handles time countdown to start the game again
    void Update()
    {
        if (expectSpace)
        {
            if (Input.GetKeyDown("space"))
            {
                startCountdown = true;
                expectSpace = false;
            }
        }

        if (startCountdown)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft > 3)
            {
                txtRef.text = "3";
            }
            else if (timeLeft > 2)
            {
                txtRef.text = "2";
            }
            else if (timeLeft > 1)
            {
                txtRef.text = "1";
            }
            else if (timeLeft > 0)
            {
                txtRef.text = "Go!";
            }
            else
            {
                txtRef.enabled = false;
                shouldMove = true;
                timeLeft = 4;
                startCountdown = false;
            }
        }
    }
    // Method to take away a life when the ship collides with another object
    void OnTriggerEnter2D(Collider2D other)
    {
        shouldMove = false; // Stopping the enemy movement temporarily when the player loses a life
        GameObject obj = other.transform.gameObject;
        Destroy(obj); // Destroys the object the ship collided with
        // Code for animation goes here
        lives--; // Subtracts a life when the ship collides with another object
        if (lives > 0) // If there are more lives left, keep playing
        {
			if (lives == 2) 
			{
				Destroy(livesDisplay3);
                lostLifeText(lives);
			} 
			else if (lives == 1) 
			{
				Destroy(livesDisplay2);
                lostLifeText(lives);
			}
        }
        else // Else, Game Over
        {
            Destroy(ship1);
            Destroy(livesDisplay1);
            Application.LoadLevel("GameOver");
        }       
    }

    // Method to display guiText when the player loses a life
    private void lostLifeText(int l)
    {
        txtRef.enabled = true;
        txtRef.text = "Lives Remaining: " + l 
            + "\n Press the SPACE button to continue";
        expectSpace = true;
    }
}
