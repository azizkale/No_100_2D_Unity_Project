using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro;
    public GameObject diziKupler;
    public GameObject gameCanvas;
    void Start()
    {
        PlayerPrefs.SetInt("animIntro", 0);
        if (PlayerPrefs.GetInt("animIntro") == 0)
        {
            diziKupler.SetActive(false);
            gameCanvas.SetActive(false);
            animIntro.SetTrigger("fire");
            PlayerPrefs.SetInt("animIntro", 1);
        }
        if (PlayerPrefs.GetInt("animIntro") == 1)
        {
        }
        

    }

    private void Update()
    {
        
    }

    public void watchAgain()
    {
        animIntro.SetTrigger("fire");
        Debug.Log("watch again");
    }

    public void dontShowAgain()
    {
        //animIntro.StopPlayback();
        Debug.Log("dont watch again");
    }

    public void showAnimationIntro()
    {
        if (PlayerPrefs.GetInt("animIntro") == 0)
        {
            animIntro.SetTrigger("fire");
            PlayerPrefs.SetInt("animIntro", 1);
        }

    }
}
