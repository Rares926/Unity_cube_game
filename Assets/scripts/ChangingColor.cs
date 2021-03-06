using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    MeshRenderer cubeMeshRenderer;
    [SerializeField] [Range(0f, 3f)] float changeTime;
    [SerializeField] Color[] myColor;
    int colorIndex = 0;
    float t = 0f;
    int len;
     void Start()
    {
        cubeMeshRenderer = GetComponent<MeshRenderer>();
        len = myColor.Length;
    }
    void Update()
    {
        cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColor[colorIndex], changeTime*Time.deltaTime);
        t = Mathf.Lerp(t, 1,changeTime*Time.deltaTime);
        if(t>.9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}

