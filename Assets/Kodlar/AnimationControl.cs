using UnityEngine;

public class AnimationControl : MonoBehaviour
{
   
    void Start()
    {

    }


    public void watchAgain()
    {
        gameObject.GetComponent<Animator>().Play("Intro", -1, 0);

    }

    public void dontShowAgain()
    {
        //anim.SetActive(false);
    }

    public void showAnimationIntro(GameObject gameobject)
    {

        gameobject.SetActive(true);
        //GameObject.FindWithTag("House").activeSelf = false;

    }
}
