using UnityEngine;

public class Memory : MonoBehaviour
{
    OyunKontrolKod oyunKontrol;
    public Texture2D[] textures;

    // Start is called before the first frame update
    void Start()
    {
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrolTag").GetComponent<OyunKontrolKod>();
        startFromMemory();
    }

    public void saveAndCancelGame()
    {
        foreach (GameObject item in oyunKontrol.clonelar)
        {
            PlayerPrefs.SetString(item.name, item.tag);           
        }
        Application.Quit();
    }

    int index = 0;
    public void startFromMemory()
    {
        foreach (GameObject item in oyunKontrol.clonelar)
        {           
            if (PlayerPrefs.GetString(item.name) == "yesil")
            {
                item.tag = "yesil";
                item.layer = 2; // yeşil küpe tıklanmasın diye      
                item.GetComponent<Renderer>().material.mainTexture = oyunKontrol.sayilar[index];
                index++;
                item.transform.rotation = Quaternion.Euler(90, 0, -180);
            }
            else if (PlayerPrefs.GetString(item.name) == "mavi")
            {
                item.tag = "mavi";
                item.layer = 0;
                item.GetComponent<Renderer>().material.mainTexture = textures[1];
            }
            else if (PlayerPrefs.GetString(item.name) == "kirmizi")
            {
                item.tag = "kirmizi";
                item.layer = 2;
                item.GetComponent<Renderer>().material.mainTexture = textures[2];
            }
        }
    }
}
