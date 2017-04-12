using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody2D bullet;
    public static bool bulletExists = false;

    // Use this for initialization
    void Start ()
    {
        bullet = GetComponent < Rigidbody2D > ();   
    }

	// Update is called once per frame
	void Update ()
    {
        bullet.transform.Translate(Vector3.right * .25F);
    }

    void OnBecameInvisible()
    { 
        Destroy(gameObject);
        bulletExists = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.transform.gameObject;
        Destroy(obj);
        Destroy(this.gameObject);
        bulletExists = false;
    }
}
