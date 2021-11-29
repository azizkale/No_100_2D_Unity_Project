using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationControl : MonoBehaviour
{
    public Animator animIntro, animScorBoard;
    public GameObject diziKupler;
    public GameObject gameCanvas;


    public void Start()
    {
        //PlayerPrefs.DeleteAll();
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
        if(numberOfCube == 3)
            animScorBoard.SetTrigger("fireScorBoard");
        else if (numberOfCube == 10)
            animScorBoard.SetTrigger("fireScorBoard");
    }
}
