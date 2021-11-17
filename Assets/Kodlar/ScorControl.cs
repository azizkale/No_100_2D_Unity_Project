using TMPro;
using UnityEngine;

public class ScorControl : MonoBehaviour    
{
    public static TextMeshProUGUI highScore;
    public static TextMeshProUGUI score;   

    // Start is called before the first frame update
    void Start()
    {
        //instances
        score = GameObject.FindWithTag("textScore").GetComponent<TextMeshProUGUI>();
        highScore = GameObject.FindWithTag("textHighScore").GetComponent<TextMeshProUGUI>();
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
