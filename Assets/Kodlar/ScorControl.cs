using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorControl : MonoBehaviour    
{
    public static Text highScore;
    public static Text score;   

    // Start is called before the first frame update
    void Start()
    {
        //instances
        score = GameObject.FindWithTag("textScore").GetComponent<Text>();
        highScore = GameObject.FindWithTag("textHighScore").GetComponent<Text>();
        // assined the high score from local storage
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }

   public static void saveHighScore()
    {
        int scr = int.Parse(score.text);
        int hScr = int.Parse(highScore.text);
        if (scr > hScr)
        {
            hScr = scr;
            highScore.text = hScr.ToString();
            PlayerPrefs.SetInt("highScore", hScr);
        }
    }
}
