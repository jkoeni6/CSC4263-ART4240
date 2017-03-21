using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private GameObject player;
	private float theY;

	void Start (){
		player = GameObject.Find ("Ship_player");
	}


	void Update () {
		if (Input.GetKeyDown("up")) {
			if (transform.position.y == 4) {
				transform.position = transform.position;
			} else {
				theY = transform.position.y + 2;
				transform.position = new Vector3(transform.position.x, theY, transform.position.z);
			}
		} 
		else if(Input.GetKeyDown("down")){
			if (transform.position.y == -4) {
				transform.position = transform.position;
			} else {
				theY = transform.position.y - 2;
				transform.position = new Vector3(transform.position.x, theY, transform.position.z);
			}
		}
}
}
