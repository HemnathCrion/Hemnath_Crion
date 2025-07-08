using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Change : MonoBehaviour
{
    private Renderer cube_renderer;

    private Color[] color = new Color[]
    {
        Color.red, // Red
        Color.green, // Green
        Color.blue, // Blue
        Color.yellow, // Yellow
        Color.magenta, // Magenta
        Color.cyan // Cyan
};
    private int currentColorIndex = 0;
   // private float colorChnageSpeed = 1f;
   // private float colorChangeTime = 0f;
// Start is called before the first frame update
void Start()
    {
        cube_renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform == transform)
                {
                    ChangeColor();
                }
            }
        }
    void ChangeColor()
        {
            currentColorIndex = (currentColorIndex + 1) % color.Length;
            cube_renderer.material.color = color[currentColorIndex];
        }
    }














    //colorChangeTime += Time.deltaTime;

    //    if(colorChangeTime >= colorChnageSpeed )
    //    {
    //        currentColorIndex = (currentColorIndex + 1) % color.Length;

    //        cube_renderer.material.color = color[currentColorIndex];

    //        colorChangeTime = 0f;
    //    }
}
