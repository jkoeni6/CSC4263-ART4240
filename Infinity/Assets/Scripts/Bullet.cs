using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int speed = 1;
    Rigidbody2D bullet;


    // Use this for initialization
    void Start () {
         bullet = GetComponent < Rigidbody2D > ();
        
    }
	

	// Update is called once per frame
	void Update () {
        bullet.transform.Translate(Vector3.right);
    }


    void OnBecameInvisible()
    { 
        Destroy(gameObject);
    }

}
