using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public static int health; // Health variable for all enemies
    private int currentHealth; // Health of the specific enemy
    private GameObject enemy; // Private gameobject to instantiate for all "Enemy 2" tagged enemies

	// Initialize health to 2 for "Enemy 2" tagged enemies
	void Start()
    {
        health = 2; // Setting health of all "Enemy 2" enemies intially to 2
        currentHealth = health; // Giving all the enemies their currentHealth which is initially set to health
        enemy = GameObject.FindGameObjectWithTag("Enemy 2"); // Giving all "Enemy 2" enemies their own instance (previoudy they all shared health without this)
	}
	

	// Method to apply damage to the enemy and destroy the enemy if their health reaches 0
	public static int applyDamage(GameObject go)
    {
        go.GetComponent<enemyHealth>().currentHealth -= 1;
        if (go.GetComponent<enemyHealth>().currentHealth == 0)
            Destroy(go);
        return go.GetComponent<enemyHealth>().currentHealth; // Returns the currentHealth of the enemy so Bullet.cs can determine if score should be given
	}
}
