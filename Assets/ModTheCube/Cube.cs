using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float Red_color;
    public float Green_color;
    public float Blue_color;
    public float Opacity;

    //scale variables
    float ScaleMultiplyer;

    //cube rotation speed
    float speed;

    

    void Start()
    {
        //randomising starting colors
        Red_color = Random.Range(0f, 1.0f);
        Green_color = Random.Range(0f, 1.0f);
        Blue_color = Random.Range(0f, 1.0f);
        Opacity = Random.Range(0f, 1.0f);


        //position declaration
        float x = Random.Range(0.0f, 5.0f);
        float y = Random.Range(0.0f, 5.0f);
        float z = Random.Range(0.0f, 5.0f);

        //position established
        transform.position = new Vector3(x, y, z);


        //randomized scale
        ScaleMultiplyer = Random.Range(0.9f, 5.0f);
        transform.localScale = Vector3.one * ScaleMultiplyer;


        //randomizing speed rotation
        speed = Random.Range(10f, 20.0f);


      
        //color changing over time
        InvokeRepeating("ChangeColor", 0f, 0.01f);
    }

    void Update()
    {

        transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f);


    }

    //changing the color over time function:
    void ChangeColor()
    {
        Red_color += 0.005f;
        Green_color += 0.001f;
        Blue_color += 0.002f;

        Material material = Renderer.material;
        material.color = new Color(Red_color, Green_color,
        Blue_color, Opacity);
    }
}