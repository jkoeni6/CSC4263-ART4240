using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public static float speed = 6.0f;
    public Transform target;
    public GameObject Sheet;

    // Booleans to spawn new sheet and stop FixedUpdate()
    private bool shouldSpawn;
    private bool stopUpdate;

    void Start()
    {
        shouldSpawn = false;
        stopUpdate = false;
    }
	
	// Method that moves enemies towards player when shouldMove == true
	void FixedUpdate()
    {
        if (shipCollision.shouldMove == true)
        {
            if (!stopUpdate)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                if (transform.position == target.position)
                {
                    stopUpdate = true;
                    shouldSpawn = true;
                }
            }

            if (shouldSpawn)
            {
                spawnNewSheet();
                shouldSpawn = false;
            }
        }
	}

    // Method to destroy the bullet when it leaves the screen
    public  void spawnNewSheet()
    {
        Sheet = Instantiate(Sheet, new Vector3(30, -1.93589F, 0), Quaternion.identity);
        speed += 4.0f;
    }
}
