﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro;
    public GameObject diziKupler;
    public GameObject gameCanvas;
    Animator animScorBoard, animHidingAvatar, animFinalScene, animFailure;

    public void Start()
    {
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

        if (numberOfCube == 20 || numberOfCube == 40 || numberOfCube == 60 || numberOfCube == 80 || (numberOfCube >= 95 && numberOfCube <= 100))
        {
            animScorBoard.SetBool("playScoreBoardAnimation", true);
        }

        else
        {
            animScorBoard.SetBool("playScoreBoardAnimation", false);
        }

    }

    public void hidingAvatarAnimation(int numberOfCube)
    {
        
        animHidingAvatar = GameObject.FindGameObjectWithTag("HidingAnimation").GetComponent<Animator>();
        if (
            numberOfCube == 20 || 
            numberOfCube == 40 || 
            numberOfCube == 60 || 
            numberOfCube == 80 || 
            numberOfCube == 95 || 
            numberOfCube == 97
            )
            animHidingAvatar.SetBool("showAnimation", true);
        else
            animHidingAvatar.SetBool("showAnimation", false);         
    }

    public void finalSceneAnimation()
    {
        // to stop hiding avatar animation
        animHidingAvatar = GameObject.FindGameObjectWithTag("HidingAnimation").GetComponent<Animator>();
        animHidingAvatar.SetBool("showAnimation", false);

        // to start final scene animation
        animFinalScene = GameObject.FindGameObjectWithTag("finalSceneAnim").GetComponent<Animator>();
        animFinalScene.SetTrigger("finalScene");        
    }

    public void gameFailureAnimation()
    {
        // to stop hiding avatar animation
        animHidingAvatar = GameObject.FindGameObjectWithTag("HidingAnimation").GetComponent<Animator>();
        animHidingAvatar.SetBool("showAnimation", false);

        // to start game over animation (failure)
        animFailure = GameObject.FindGameObjectWithTag("gameFailure").GetComponent<Animator>();
        animFailure.SetTrigger("gameFailure");        
    }
    
}
