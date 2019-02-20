using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreVar : MonoBehaviour
{


    public int score;
    public Text totalScore = null;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;      
    }

    // Update is called once per frame
    void Update()
    {
        totalScore.text = "Jewels Collected: " + score + "/ 9";

    }
}
