using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void watchAgain()
    {
        anim.Play("Intro");
    }

    public void dontShowAgain()
    {
        SceneManager.LoadScene("no100_11");
    }
}
