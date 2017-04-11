using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCollision : MonoBehaviour
{
    private GameObject ship1;
    public static int lives;

    void Start()
    {
        ship1 = GameObject.Find("Ship_player");
        lives = 3;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        lives--;
        if (lives > 0)
        {
            print(lives);
        }
        else
        {
            Destroy(ship1);
            print(lives);
        }       
    }
}
