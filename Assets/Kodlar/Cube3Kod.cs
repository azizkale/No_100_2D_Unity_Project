using System.Collections;
using UnityEngine;


public class Cube3Kod : MonoBehaviour
{

    Renderer render;
    public GameObject kup;
    OyunKontrolKod oyunKontrol;
    bool ilkTiklama;

    

    void Start()
    {
        render = GetComponent<Renderer>();
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrolTag").GetComponent<OyunKontrolKod>();

    }


    
    void OnMouseDown()
    {
        KutularaTiklama();       
        StartCoroutine(DonmeAnimasyonu());
        Debug.Log(name);
    }
 
    private void Update()
    {

       

    }

    int index = 0;
    public void KutularaTiklama()
    {       
        int syc = System.Int32.Parse(this.name);// clone küpün adını int e çevirir

        // altattaki foreach döngüsü yesil olan clone küpe sayı veriri
        foreach (GameObject item in oyunKontrol.clonelar)
        {
            if (item.tag=="yesil")
            {
                index++;
            }
        }

        //alttaki for döngüsü ile  her tıklandığında tüm clone küpler taranır ve mavi kırmızı veya yeşil olur.
        for (int i = 0; i < 255; i++)
        {
            //oyunKontrol.clonelar[i].GetComponent<Renderer>().material.mainTexture != oyunKontrol.textures[0]
            if (oyunKontrol.clonelar[i].tag!="yesil") // yeşil olan küp rengi değişmesin diye
            {                
                render.material.mainTexture = oyunKontrol.sayilar[index];
             
                tag = "yesil";
                oyunKontrol.clonelar[syc].layer = 2; // yeşil küpe tıklanmasın diye                

                if ((i == syc + 3 || i == syc - 3 || i == syc + 48 || i == syc - 48 || i == syc + 30 || i == syc - 30 || i == syc + 34 || i == syc - 34)) // tıklanan seçilir kılavuz kareler belirlenir mavi yapılır
                {
                    oyunKontrol.clonelar[i].GetComponent<Renderer>().material.mainTexture = oyunKontrol.textures[1];
                    oyunKontrol.clonelar[i].tag = "mavi";
                    oyunKontrol.clonelar[i].layer = 0;
                }

                else // yeşil ve mavi olmayanlar kırmızı olur
                {
                    oyunKontrol.clonelar[i].GetComponent<Renderer>().material.mainTexture = oyunKontrol.textures[2];
                    oyunKontrol.clonelar[i].tag = "kirmizi";
                    oyunKontrol.clonelar[i].layer = 2;
                }                
            }
            
        }
        index++; // yesil olan küpe sayı verme index i
    }

    public IEnumerator DonmeAnimasyonu()
    {
        for (int i = 0; i <= 3; i++)
        {
            this.transform.rotation = Quaternion.Euler(-i * 30, 0, -180);
            yield return new WaitForSeconds(0.1f);
        }      
    }

    
}