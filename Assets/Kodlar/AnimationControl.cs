﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro;
    public GameObject diziKupler;
    public GameObject gameCanvas;
    Animator animScorBoard;

    public void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("animIntro") == 0)
        {
            diziKupler.SetActive(false);
            gameCanvas.SetActive(false);
            animIntro.SetTrigger("fire");
        }


    }

    public void watchAgain()
    {
        diziKupler.SetActive(false);
        gameCanvas.SetActive(false);
        animIntro.GetComponent<Animator>().Play("Intro2", -1, 0);
    }

    public void dontShowAgain()
    {
        PlayerPrefs.SetInt("animIntro", 1);       
        SceneManager.LoadScene("no100_11");
    }

    public void scoarBoardSwingig(int numberOfCube)
    {
        animScorBoard = GameObject.FindGameObjectWithTag("ScorBoardObject").GetComponent<Animator>();
        if (numberOfCube == 40) 
            animScorBoard.SetBool("playScoreBoardAnimation", true);           
        
        else if (numberOfCube == 60)        
            animScorBoard.SetBool("playScoreBoardAnimation", true);
        
        else if (numberOfCube == 70)                  
            animScorBoard.SetBool("playScoreBoardAnimation", true);
        
        else if (numberOfCube == 85)
            animScorBoard.SetBool("playScoreBoardAnimation", true);

        else if (numberOfCube == 95)
            animScorBoard.SetBool("playScoreBoardAnimation", true);
        
        else
            animScorBoard.SetBool("playScoreBoardAnimation", false);

    }
    }
