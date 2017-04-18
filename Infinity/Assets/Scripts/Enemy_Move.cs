using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {
    public float speed = 6.0f;
    public Transform target;
	
	// Method that moves enemies towards player when shouldMove == true
	void FixedUpdate ()
    {
        if (shipCollision.shouldMove == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
	}
}
