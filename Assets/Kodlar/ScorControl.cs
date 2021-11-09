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
        score = GameObject.FindWithTag("textScore").GetComponent<Text>();
        highScore = GameObject.FindWithTag("textScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
