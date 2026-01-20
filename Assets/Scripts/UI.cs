using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    void Awake()
    {
        instance = this;    
    }

    void Start()
    {
        if (scoreText != null)
        {
            scoreText.text="Points:0";
        }
    }
    // Update is called once per frame
    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
