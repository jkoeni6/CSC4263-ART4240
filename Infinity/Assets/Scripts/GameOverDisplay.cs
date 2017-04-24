using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDisplay : MonoBehaviour
{
    public GUIText finalScore;
    int score;
    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "You scored: " + score;
    }
}
