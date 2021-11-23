using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject go;
    void Start()
    {
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            go.SetActive(true);
        }  if (Input.GetKeyDown(KeyCode.B))
        {
            go.SetActive(false);
        }
    }

    public void watchAgain()
    {
       
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
