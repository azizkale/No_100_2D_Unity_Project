using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3Kod : MonoBehaviour
{
    Renderer render;
    public GameObject kup;
    OyunKontrolKod oyunKontrol;
    //bool ilkTiklama;
    bool availableMove; // if there are availables move(blue cube) it turns to true
    ScorControl scorControl;
    AnimationControl animcontrol;
    Memory memo;

    void Start()
    {
        render = GetComponent<Renderer>();
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrolTag").GetComponent<OyunKontrolKod>();
        scorControl = new ScorControl();
        animcontrol = new AnimationControl();
        memo = new Memory();
    }

    void OnMouseDown()
    {
        KutularaTiklama();       
        Debug.Log(name);        
    } 
    
   
    public void KutularaTiklama()
    {
        int index = 0;
        int syc = System.Int32.Parse(this.name);// clone küpün adını int e çevirir

        availableMove = false; // to control if tge game finish
        
        //spinning animation
        StartCoroutine(DonmeAnimasyonu(oyunKontrol.clonelar[syc]));

        // altattaki foreach döngüsü yesil olan clone küpe sayı veriri
        foreach (GameObject item in oyunKontrol.clonelar)
        {
            if (item.tag=="yesil")
            {   
                index++;
                animcontrol.scoarBoardSwingig(index);
                animcontrol.hidingAvatarAnimation(index);               
            }
        }

        //alttaki for döngüsü ile  her tıklandığında tüm clone küpler taranır ve mavi kırmızı veya yeşil olur.
        for (int i = 0; i < 255; i++)
        {            
            if (oyunKontrol.clonelar[i].tag!="yesil") // yeşil olan küp rengi değişmesin diye
            {
                tag = "yesil";
                render.material.mainTexture = oyunKontrol.sayilar[index];                

                oyunKontrol.clonelar[syc].layer = 2; // yeşil küpe tıklanmasın diye                

                if ((i == syc + 3 || i == syc - 3 || i == syc + 48 || i == syc - 48 || i == syc + 30 || i == syc - 30 || i == syc + 34 || i == syc - 34)) // tıklanan seçilir kılavuz kareler belirlenir mavi yapılır
                {
                    oyunKontrol.clonelar[i].GetComponent<Renderer>().material.mainTexture = oyunKontrol.textures[1];
                    oyunKontrol.clonelar[i].tag = "mavi";
                    oyunKontrol.clonelar[i].layer = 0;

                    availableMove = true;
                }

                else // yeşil ve mavi olmayanlar kırmızı (tagli) olur
                {
                    oyunKontrol.clonelar[i].GetComponent<Renderer>().material.mainTexture = oyunKontrol.textures[2];
                    oyunKontrol.clonelar[i].tag = "kirmizi";
                    oyunKontrol.clonelar[i].layer = 2;
                }                
            }            
        }

        // code below saves texture number of every cubes in evey click to be able to load from memoy
        memo.saveTextureNumber("texture:"+this.name, index);

        index++; // yesil olan küpe sayı verme index i

        //--------- in every click it sets the score----------------
        scorControl.setAndSaveScores(index);

        // code below checks that tge game finished or goes on
        gameOver(availableMove, index);

    }

    public IEnumerator DonmeAnimasyonu(GameObject go) // arbitary variable
    {
        int index = 1;
        for (int i = 0; i <= index; i++)
        {           
            go.transform.rotation = Quaternion.Euler(-i * 5, 0, -180);
            yield return new WaitForSeconds(0.1f);
            index++;
        }
    }

    public IEnumerator fallingAnimation()
    {
         foreach (GameObject cube in oyunKontrol.clonelar)
        {
            // fall the cudes whose MeshRenderer is enable and whose tag is not kirmizi
            if (cube.GetComponent<MeshRenderer>().enabled && cube.tag != "kirmizi")
            {
                for (int i = 0; i <= 10; i++)
                {
                    cube.transform.position = new Vector3(
                        cube.transform.position.x,
                        cube.transform.position.y - i,
                        cube.transform.position.z - 1);
                    yield return new WaitForSeconds(0.0001f);
                }
            }            
        }
    }

    public void gameOver(bool availableMove, int score )
    {
        if (!availableMove)
        {
            if (score < 100)
            {
                Debug.Log("kazanamadınız");
            }

            if (score > 80)
            {
                animcontrol.finalSceneAnimation();
                StartCoroutine(fallingAnimation());
            }
        }
    }
}