using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private GameObject player;
	private float theY;
    public GameObject laserbeam;
	public static string inputKeyUp;
	public static string inputKeyDown;

	void Start()
    {
		player = GameObject.Find("Ship_player");
		inputKeyUp = "up";
		inputKeyDown = "down";
	}

	void Update()
    {
        if (shipCollision.shouldMove == true)
        {
            // Code that moves the ship up a lane when the up arrow is pressed
			if (Input.GetKeyDown(inputKeyUp))
            {
                if (transform.position.y == 4)
                {
                    transform.position = transform.position;
                }
                else
                {
                    theY = transform.position.y + 2;
                    transform.position = new Vector3(transform.position.x, theY, transform.position.z);
                }
            }
            // Code that moves the ship down a lane when the down arrow is pressed
			else if (Input.GetKeyDown(inputKeyDown))
            {
                if (transform.position.y == -4)
                {
                    transform.position = transform.position;
                }
                else
                {
                    theY = transform.position.y - 2;
                    transform.position = new Vector3(transform.position.x, theY, transform.position.z);
                }
            }

            // Code that fires a laserbeam when the space key is pressed
            if (Input.GetKeyDown("space"))
            {
                if (Bullet.bulletExists == false)
                {
                    Bullet.bulletExists = true;
                    Instantiate(laserbeam, transform.position, Quaternion.identity);
                }
            }
        }
    }

}
