using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrolKod : MonoBehaviour
{
    public GameObject kup;
    public GameObject zemin;
    public GameObject light;
    public GameObject isiklar;
    Vector3 vec;
    GameObject clone;
    public Texture2D[] textures;
    public GameObject[] clonelar;
    public Texture2D[] sayilar;
  


    void Start()
    {      

        KupleriOlusturma();
        zemin.transform.position = new Vector3(-7.2f,4f,-2.5f);
        zemin.transform.rotation = Quaternion.Euler(new Vector3(-90f,0f,0f));
       
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
                
                clone.name = sayac.ToString();               
                clone.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
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

                // Lights - Every Cube has own light
                // Make a game object
                GameObject lightGameObject = new GameObject("The Light" + sayac);
                lightGameObject.transform.SetParent(isiklar.transform);
                // Add the light component
                Light lightComp = lightGameObject.AddComponent<Light>();
                lightComp.range = 1;
                isiklar.transform.rotation = Quaternion.Euler(new Vector3(-270, 0,0));
                // Set the position (or any transform property)
                lightGameObject.transform.position = new Vector3(vec.x, vec.y, vec.z);

                sayac++;
            }
        }
    }

   
}
