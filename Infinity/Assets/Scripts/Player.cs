using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private GameObject player;
	private float theY;
    public GameObject laserbeam;

	void Start (){
		player = GameObject.Find ("Ship_player");
	}

	void Update () {
        if(shipCollision.shouldMove == true)
        {
            // Code that moves the ship up a lane when the up arrow is pressed
            if (Input.GetKeyDown("up"))
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
            else if (Input.GetKeyDown("down"))
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
