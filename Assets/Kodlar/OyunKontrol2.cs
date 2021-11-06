using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol2 : MonoBehaviour
{
    public GameObject kup;
    public GameObject zemin1;
    public GameObject zemin2;
    public GameObject zemin3;
    public GameObject zemin4;
    public GameObject zemin5;
    public GameObject zemin6;
    Vector3 vec;
    GameObject clone;
    public Texture2D[] textures;
    public GameObject[] clonelar;
    public Texture2D[] sayilar;



    void Start()
    {

        KupleriOlusturma(zemin1);
        KupleriOlusturma(zemin2);
        KupleriOlusturma(zemin3);
        KupleriOlusturma(zemin4);
        KupleriOlusturma(zemin5);
        KupleriOlusturma(zemin6);


        //zemin1.transform.position = new Vector3(-7.2f, 4f, -2.5f);
        //zemin1.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));

    }



    public void KupleriOlusturma(GameObject zemin)
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
                sayac++;
            }
        }
    }
}
