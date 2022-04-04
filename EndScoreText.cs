using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScoreText : MonoBehaviour
{
    TMP_Text endScore;
    ScoreBoard scoreBoard;
    private void Start()
    {
        endScore = GetComponent<TMP_Text>();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void Update()
    {
        endScore.text = "Score\n" + scoreBoard.score.ToString() + "\nHigh Score\n" + scoreBoard.highscore.ToString();

    }
}
