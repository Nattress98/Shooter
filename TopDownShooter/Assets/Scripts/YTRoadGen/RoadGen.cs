using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour
{
    Camera cam;
    void Update()
    {
        Ray mouseRay = cam.ScreenPointToRay(Input.mousePosition);
        Vector3 mousePos = Vector3.zero;
        if(mouseRay.direction.y != 0)
        {
            float dstToXZPlane = Mathf.Abs(mouseRay.origin.y / mouseRay.direction.y);
            mousePos = mouseRay.GetPoint(dstToXZPlane);
        }
        if (Input.GetMouseButtonDown(1))
        {
            
        }
    }
}
