using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro;
    public GameObject diziKupler;
    public GameObject gameCanvas;
    void Start()
    {
       
        if (PlayerPrefs.GetInt("animIntro") == 0)
        {
            diziKupler.SetActive(false);
            gameCanvas.SetActive(false);
            animIntro.SetTrigger("fire");           
        }
       
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
