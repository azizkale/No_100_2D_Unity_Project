using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoruntuAcisi : MonoBehaviour
{
    //görüntü açısı kodları

    public GameObject PerspektifCamera1;
    public GameObject OrtogonalCamera1;

    public GameObject[] PerspektifLights;
    public GameObject OrtogonalLights;

    void Start()
    {
        PerspektifCamera1 = GameObject.FindGameObjectWithTag("perspektifCameraTag");
        OrtogonalCamera1= GameObject.FindGameObjectWithTag("ortogonalCameraTag");

        for (int i = 0; i < PerspektifLights.Length; i++)
        {
            PerspektifLights[i] = GameObject.FindGameObjectWithTag("perspektifLightTag");
        }

        OrtogonalLights = GameObject.FindGameObjectWithTag("ortogonalLightTag");
    }

    
    void Update()
    {
       
    }

    public void PerspektifGoruntu()
    {
        PerspektifCamera1.GetComponent<Camera>().enabled = true;
        foreach (GameObject item in PerspektifLights)
        {
            item.GetComponent<Light>().enabled = true;
        }

        OrtogonalCamera1.GetComponent<Camera>().enabled = false;
        OrtogonalLights.GetComponent<Light>().enabled = false;
    }

    public void OrtogonalGoruntu()
    {
        PerspektifCamera1.GetComponent<Camera>().enabled = false;
        foreach (GameObject item in PerspektifLights)
        {
            item.GetComponent<Light>().enabled = false;
        }

        OrtogonalCamera1.GetComponent<Camera>().enabled = true;
        OrtogonalLights.GetComponent<Light>().enabled = true;
    }
}
