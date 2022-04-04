using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    TMP_Text scoreBoard;
    
    public int score;
    public int highscore;
    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = GetComponent<TMP_Text>();
        scoreBoard.text = "0";
        highscore = PlayerPrefs.GetInt("highscore", highscore);

    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreBoard.text = score.ToString();
    }

    private void Update()
    {
        if (score > highscore)
        {
            highscore = score;


            PlayerPrefs.SetInt("highscore", highscore);
        }
    }



}
