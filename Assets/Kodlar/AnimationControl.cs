using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    void Start()
    {

        Screen.fullScreen = !Screen.fullScreen; // to fit the screen to the device's screen        
    }


    public void watchAgain()
    {
        Screen.fullScreen = !Screen.fullScreen; // to fit the screen to the device's screen
        SceneManager.LoadScene("IntroAnimation");
    }

    public void dontShowAgain()
    {
        PlayerPrefs.SetInt("animationReshowing", 1);
        SceneManager.LoadScene("no100_11");
    }
}
