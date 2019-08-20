using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    public GameObject slab;
    public static int Gamescore = 0;
    public Text scoreText;
    public Text declareResult;
    private float Score_time=0;
    void Start()
    {
        scoreText.text = "";
        declareResult.text = "";
    }

    void Update()
    {
        scoreText.text = "Score : " + score;
       
       
            if (Time.time - Score_time > 2f)
            {
                ++score;
            Score_time = Time.time;
            if (score >= 40)
            {
                declareResult.text = "The porter did the job :)";
                Time.timeScale = 0;
            }
            else
            {
                declareResult.text = "The porter is alone :("; 
            }

        }
    }
}
