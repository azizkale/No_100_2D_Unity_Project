﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrolKod : MonoBehaviour
{
    public GameObject kup;
    public GameObject zemin;
    Vector3 vec;
    GameObject clone;
    public Texture2D[] textures;
    public GameObject[] clonelar;
    public Texture2D[] sayilar;
    public Shader myShader;
    AnimationControl animControl;

    void Start()
    {
        Screen.fullScreen = !Screen.fullScreen; // to fit the screen to the device's screen


        KupleriOlusturma();
        zemin.transform.position = new Vector3(-7.2f,0.25f,-2.5f);
        zemin.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
        animControl = new AnimationControl();
        animControl.showAnimationIntro();
    }   

    public void KupleriOlusturma()
    {
        int sayac = 0;
        for (int i = 0; i < 16; i++)
        {
            vec.z = 4.5f - i;
            for (int j = 0; j < 16; j++)
            {
                vec.x = -6 + j;
                clone = Instantiate(kup, vec, Quaternion.identity) as GameObject;
                clone.transform.SetParent(zemin.transform);

                //Shader setting
                clone.GetComponent<Renderer>().material.shader = myShader;

                clone.name = sayac.ToString();               
                clone.transform.localScale = new Vector3(0.93f, 0.93f, 0.93f);
                clonelar[sayac] = clone;
                clone.GetComponent<Renderer>().material.mainTexture = textures[1];
                clone.tag = "mavi";              
               
                //fazlalık küplerin meshRenderer ları kapatılır.
                if (sayac >= 0 && sayac <= 47 || sayac >= 208 && sayac <= 255 || sayac % 16 == 0 || sayac % 16 == 1 || sayac % 16 == 2 || sayac % 16 == 13 || sayac % 16 == 14 || sayac % 16 == 15)
                {   
                    // gösterilmeyen kup ler tıklamalara tepki vermesi önlenir
                    Destroy(clone.GetComponent<BoxCollider>());
                    clone.GetComponent<MeshRenderer>().enabled = false;
                }
                sayac++;
            }
        }
    }

    public void resetGame()
    {
        foreach (GameObject item in clonelar)
        {
            item.tag = "mavi";
            item.layer = 0;
            item.GetComponent<Renderer>().material.mainTexture = textures[1];
            ScorControl.score.text = "0";
            PlayerPrefs.SetInt("score", 0);
            
        }
    }
   

   
}
