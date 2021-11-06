using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraPositions : MonoBehaviour
{


    void Start()
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer)
            Debug.Log("Do something special here");
    }
}