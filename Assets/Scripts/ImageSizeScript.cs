using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class ImageSizeScript : MonoBehaviour
{
    public GameObject Image;
    public GameObject SizeSlider;
    public GameObject HeightSlider;

    float sizeX;
    float sizeY;
    float sizeZ;

    private void Start()
    {
        sizeX = Image.GetComponent<Transform>().localScale.x;
        sizeY = Image.GetComponent<Transform>().localScale.y;
        sizeZ = Image.GetComponent<Transform>().localScale.z;
    }
    public void changeWidth()
    {
        HeightSlider.GetComponent<Slider>().value = 1;
        float size = SizeSlider.GetComponent<Slider>().value;
        Image.transform.localScale = new Vector3(sizeX * size, sizeY,sizeZ);
    }
    public void changeHeight()
    {
        SizeSlider.GetComponent<Slider>().value = 1;
        float size = HeightSlider.GetComponent<Slider>().value;
        Image.transform.localScale = new Vector3(sizeX , sizeY*size, sizeZ);
    }

}
