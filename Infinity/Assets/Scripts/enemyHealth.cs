using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public static int health; // Health of the enemy

	// Initialize health to 2 for "Enemy 2" tagged enemies
	void Start()
    {
        health = 2;
	}
	

	// Method to apply damage to the enemy
	public static void applyDamage()
    {
        health -= 1;
	}
}
