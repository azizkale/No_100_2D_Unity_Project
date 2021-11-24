using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject go;
    void Start()
    {
        PlayerPrefs.SetInt("animation", 0);
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

        if (PlayerPrefs.GetInt("animation") == 0)
        {
            PlayerPrefs.SetInt("animation", 1);
            go.SetActive(true);
            Debug.Log(PlayerPrefs.GetInt("animation"));
        }
        if(PlayerPrefs.GetInt("animation") == 1)
        {
            PlayerPrefs.SetInt("animation", 0);
            go.SetActive(false);
            Debug.Log(PlayerPrefs.GetInt("animation"));
        }
        //return PlayerPrefs.GetInt("animation");
    }
}
