using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerbar : MonoBehaviour
{

    float my; //calculated x position of mouse
    float yMax; //max value mx can get, required for calculation

    Slider slider;

    // Use this for initialization
    void Start()
    {
        slider = GetComponent<Slider>(); //get attached slider script
        yMax = Camera.main.pixelWidth;   //max value mx can get is width of cam
    }

    // Update is called once per frame
    void Update()
    {
        my = Input.mousePosition.y; //get mouse x
        my = my / yMax;             //find ratio, get value between 1 and 0
        slider.value = my;          //slider.value can get value between 1 and 0
    }

    
}