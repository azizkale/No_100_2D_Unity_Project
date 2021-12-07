using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cancelling : MonoBehaviour
{
    ScorControl scorControl;
    Memory memo;

    private void Start()
    {
        scorControl = new ScorControl();
        memo = new Memory();

    }
    void Awake()
    {
        
    }

    void OnApplicationQuit()
    {
        scorControl.setAndSaveScores(PlayerPrefs.GetInt("score"));
        memo.saveAndCancelGame();
    }

    
}
