using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminKod : MonoBehaviour
{
    Vector3 mouseEskiKonum;
    Vector3 vec = new Vector3(0f, 0f, 0f);
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        //    mouseEskiKonum = Input.mousePosition;
        //}
         if (Input.GetMouseButton(0))
        {
            //transform.localScale += (Input.mousePosition - mouseEskiKonum) / 100;
           
            transform.rotation = Quaternion.Euler((Input.mousePosition.x - vec.x) / 50 - 90,(Input.mousePosition.y-vec.y)/50, (Input.mousePosition.z - vec.z) / 100);
            mouseEskiKonum = Input.mousePosition;
        }
    }
}
