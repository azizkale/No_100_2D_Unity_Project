using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro;
    void Start()
    {
        //PlayerPrefs.SetInt("animIntro", 0);

        if(PlayerPrefs.GetInt("animIntro") == 0)
        {
            animIntro.SetTrigger("fire");
            PlayerPrefs.SetInt("animIntro", 1);
        }
    }

    private void Update()
    {
        
    }

    public void watchAgain()
    {
       
    }

    public void dontShowAgain()
    {
    }

    public void showAnimationIntro()
    {

       
    }
}
