﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro;
    public GameObject diziKupler;
    public GameObject gameCanvas;

    public void Start()
    {
        PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("animIntro") == 0)
        {
            //Screen.fullScreen = !Screen.fullScreen;
            diziKupler.SetActive(false);
            gameCanvas.SetActive(false);
            animIntro.SetTrigger("fire");
        }
    }

    public void initialGame()
    {
       
    }

    private void Update()
    {
        
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
   
}
