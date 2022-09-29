using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicOptions : MonoBehaviour
{
    public Material shaderMat;

    public void changeHue(float hue)
    {
        shaderMat.SetFloat("hueModif", hue);
    }
}
