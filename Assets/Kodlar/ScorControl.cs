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
        // high score comes zero as default
        highScore = GameObject.FindWithTag("textHighScore").GetComponent<TextMeshProUGUI>();

        // first values from memory of the device
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }

    public void setAndSaveScores(int val)
    {
        //-------Score Settings------------
        PlayerPrefs.SetInt("score", val);
        score.text = val.ToString();

        //--------High Score Settings--------
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
