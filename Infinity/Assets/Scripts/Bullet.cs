using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody2D bullet;

    // Boolean to see if a bullet exists in the game world at one specific time
    public static bool bulletExists = false;
    
    // Use this for initialization
    void Start ()
    {
        bullet = GetComponent < Rigidbody2D > ();   
    }

	// Update is the method for making the bullet travel towards enemies
	void Update ()
    {
        bullet.transform.Translate(Vector3.right * .5F); // The float is a changeable speed factor
    }

    // Method to destroy the bullet when it leaves the screen
    void OnBecameInvisible()
    { 
        Destroy(gameObject);
        bulletExists = false;
    }

    // Method to destroy enemies and the bullet when they collide
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.transform.gameObject;
        Destroy(obj);
        Destroy(this.gameObject);
        bulletExists = false;
    }
}
