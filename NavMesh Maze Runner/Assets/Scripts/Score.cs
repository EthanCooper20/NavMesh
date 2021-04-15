using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score; // players score
    public Text scoreUI;

    // Use this for initialization
    void Start()
    {
        score = 0; // starting score
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score : " + score.ToString(); // display score guitext
    }
}
