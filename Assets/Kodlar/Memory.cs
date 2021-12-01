using UnityEngine;

public class Memory : MonoBehaviour
{
    OyunKontrolKod oyunKontrol;
    public Texture2D[] textures;
    Cube3Kod cube3Kod;

    void Start()
    {
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrolTag").GetComponent<OyunKontrolKod>();
        cube3Kod = new Cube3Kod();
        startFromMemory();
    }

    public void saveAndCancelGame()
    {
        foreach (GameObject item in oyunKontrol.clonelar)
        {
            PlayerPrefs.SetString("tagName: " + item.name, item.tag);           
        }
        Application.Quit();
    }

    public void saveTextureNumber(string cubeName, int index)
    {        
        PlayerPrefs.SetInt(cubeName, index);
    }

    int index = 0;
    public void startFromMemory()
    {
        foreach (GameObject item in oyunKontrol.clonelar)
        {           
            if (PlayerPrefs.GetString("tagName: " + item.name) == "yesil")
            {
                item.tag = "yesil";
                item.layer = 2; // yeşil küpe tıklanmasın diye
                item.GetComponent<Renderer>().material.mainTexture = oyunKontrol.sayilar[PlayerPrefs.GetInt("texture:" + item.name)];
                //index++;
                item.transform.rotation = Quaternion.Euler(90, 0, -180);

                //starts animation for cubes with yesil tag
                StartCoroutine(cube3Kod.DonmeAnimasyonu(item));
            }
            else if (PlayerPrefs.GetString("tagName: " + item.name) == "mavi")
            {
                item.tag = "mavi";
                item.layer = 0;
                item.GetComponent<Renderer>().material.mainTexture = textures[1];
            }
            else if (PlayerPrefs.GetString("tagName: " + item.name) == "kirmizi")
            {
                item.tag = "kirmizi";
                item.layer = 2;
                item.GetComponent<Renderer>().material.mainTexture = textures[2];
            }
        }      
    }
}
