using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Canvas canvasObjects;
    public Canvas canvasTexts;

    void Start()
    {
        canvasObjects = GetComponent<Canvas>();
        canvasTexts = GetComponent<Canvas>();
    }


    public void watchAgain()
    {
        Debug.Log("zort");
        gameObject.GetComponent<Animator>().Play("Intro", -1, 0);

    }

    public void dontShowAgain()
    {
        Debug.Log("zort");
    }

    public void showAnimationIntro()
    {
        // it disables the two canvas below on the screen to show animationIntro
        // does nothing somthing magic
        canvasObjects.enabled = false;
        canvasTexts.enabled = false;
    }
}
