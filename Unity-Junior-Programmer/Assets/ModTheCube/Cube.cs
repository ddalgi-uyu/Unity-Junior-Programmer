using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Color[] colors;
    private float timer = 0;
    private float updateTime = 2;

    void Start()
    {
        
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > updateTime)
        {
            timer = 0;

            // Color
            Material material = Renderer.material;
            int colorIndex = Random.Range(0, colors.Length);
            Color randomColor = colors[colorIndex];
            material.color = new Color(randomColor.r, randomColor.g, randomColor.b, Random.Range(0.1f, 1f));

            // Transform
            int axisX = Random.Range(-5, 5);
            int axisZ = Random.Range(-5, 5);
            transform.position = new Vector3(axisX, 4, axisZ);

            // Scale
            float scale = Random.Range(1, 5);
            transform.localScale = Vector3.one * scale;

            // Rotation
            float speed = Random.Range(0.1f, 5f);
            int randomAxis = Random.Range(0, 2);
            if (randomAxis == 0)
            {
                transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f);
            }
            else if (randomAxis == 1)
            {
                transform.Rotate(0.0f, speed * Time.deltaTime, 0.0f);
            }
            else
            {
                transform.Rotate(0.0f, 0.0f, speed * Time.deltaTime);
            }
        }
    }
}
