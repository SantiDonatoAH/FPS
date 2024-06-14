using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text txtScore;
    public int score;
    public int MaxScore = 2500;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    void Update()
    {
        if (score >= MaxScore)
        {
            txtScore.text = "Ganaste!";
        }
    }
}