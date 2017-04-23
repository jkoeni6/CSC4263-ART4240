using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bullet;
    public static int score;
    private GUIText txtRef;

    // Boolean to see if a bullet exists in the game world at one specific time
    public static bool bulletExists = false;
    
    // Initializing components 
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();   
        txtRef = GameObject.Find("Score Text").GetComponent<GUIText>();
    }

	// Update is the method for making the bullet travel towards enemies
	void Update()
    {
        bullet.transform.Translate(Vector3.right * .5F); // The float is a changeable speed factor
    }

    // Method to destroy the bullet when it leaves the screen
    void OnBecameInvisible()
    { 
        Destroy(gameObject);
        bulletExists = false;
    }

    // Method to update the score and display it
    void updateScore(int incScore)
    {
        score = score + incScore;
        txtRef.text = "Score: " + score;
    }

    // Method to handle the collision of a bullet with an enemy
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.transform.gameObject; // Gets the GameObject that the bullet collided with
        // Handler for if obj is an "Enemy 1"
        if (obj.tag == "Enemy 1")
        {
            Destroy(obj); 
            Destroy(this.gameObject);
            bulletExists = false;
            updateScore(100);
        }
        // Handler for if obj is an "Enemy 2"  
        else if (obj.tag == "Enemy 2")
        {
            int temp = enemyHealth.applyDamage(obj);
            print(temp);
            if (temp == 0)
                updateScore(200);
            Destroy(this.gameObject);
            bulletExists = false;
        }
        // Handler for if obj is an "Asteroid"
        else
        {
            Destroy(this.gameObject);
            bulletExists = false;
        }
    }
}
