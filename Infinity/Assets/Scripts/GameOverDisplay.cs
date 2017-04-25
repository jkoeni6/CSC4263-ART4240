using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDisplay : MonoBehaviour
{
    public GUIText finalScore;
    int score;


    // Use this for initialization
    void Start() {
        
        finalScore = GameObject.Find("Score Text").GetComponent<GUIText>();
        finalScore.fontSize = 30;
        finalScore.pixelOffset = new Vector2(400, -400);
        //finalScore.transform.position = new Vector3(-1, -2, 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
