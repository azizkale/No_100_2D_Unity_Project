using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("animationReshowing") == 0)
        {
            PlayerPrefs.SetInt("animationReshowing", 1);
            //SceneManager.LoadScene("IntroAnimation");
        }
        if (PlayerPrefs.GetInt("animationReshowing") == 1)
        {
            SceneManager.LoadScene("no100_11");
           
        }
        //else
            //SceneManager.LoadScene("IntroAnimation");
    }


    public void watchAgain()
    {
        PlayerPrefs.SetInt("animationReshowing", 0);
        SceneManager.LoadScene("IntroAnimation");
    }

    public void dontShowAgain()
    {
        PlayerPrefs.SetInt("animationReshowing", 1);
        SceneManager.LoadScene("no100_11");
    }
}
