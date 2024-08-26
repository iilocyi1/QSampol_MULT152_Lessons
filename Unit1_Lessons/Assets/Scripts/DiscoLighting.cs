using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoLighting : MonoBehaviour
{
    public Light discoLight;
    public Color discoLightColor;
    // Start is called before the first frame update
    void Start()
    {
        discoLightColor = Color.magenta;
           }

    // Update is called once per frame
    void Update()
    {
        discoLight.color = discoLightColor;    }
}
