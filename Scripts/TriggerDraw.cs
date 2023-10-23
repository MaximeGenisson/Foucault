using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDraw : MonoBehaviour
{

    GameObject camObject;
    GameObject brush;
    Camera drawCam;
    Renderer drawMaterial;

    public void ChangeCam(){
        camObject = GameObject.Find("Cam");
        brush = GameObject.Find("Paint");
        drawMaterial = brush.GetComponent<Renderer>();
        drawCam = camObject.GetComponent<Camera>();
        drawCam.enabled = !drawCam.enabled;
        drawMaterial.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        if (drawCam.enabled){
            camObject.GetComponent<StudioEventEmitter>().Play();
        }
        else{
            camObject.GetComponent<StudioEventEmitter>().Stop();
        }

    }

}
