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
    public GameObject Jefe;
    public GameObject Gibus;
    public GameObject WizzardHat;

    float sizeX;
    float sizeY;
    float sizeZ;
    float GibusY, GibusX, GibusZ;
    float JefeX, JefeY, JefeZ;
    float WizzardX, WizzardY, WizzardZ;

    private void Start()
    {
        sizeX = Image.GetComponent<Transform>().localScale.x;
        sizeY = Image.GetComponent<Transform>().localScale.y;
        sizeZ = Image.GetComponent<Transform>().localScale.z;

        GibusY = Gibus.GetComponent<Transform>().localScale.y;
        GibusX = Gibus.GetComponent<Transform>().localScale.x;
        GibusZ = Gibus.GetComponent<Transform>().localScale.z;

        JefeY = Gibus.GetComponent<Transform>().localScale.y;
        JefeX = Gibus.GetComponent<Transform>().localScale.x;
        JefeZ = Gibus.GetComponent<Transform>().localScale.z;

        WizzardY = Gibus.GetComponent<Transform>().localScale.y;
        WizzardX = Gibus.GetComponent<Transform>().localScale.x;
        WizzardZ = Gibus.GetComponent<Transform>().localScale.z;
    }
    public void changeWidth()
    {
        HeightSlider.GetComponent<Slider>().value = 1;
        float size = SizeSlider.GetComponent<Slider>().value;
        Image.transform.localScale = new Vector3(sizeX * size, sizeY,sizeZ);

        Jefe.transform.localPosition = new Vector3(JefeX * size, JefeY, JefeZ);
        Gibus.transform.localScale = new Vector3(GibusX * size, GibusY, GibusZ);
        WizzardHat.transform.localPosition = new Vector3(WizzardX * size, WizzardY, WizzardZ);
    }
    public void changeHeight()
    {
        SizeSlider.GetComponent<Slider>().value = 1;
        float size = HeightSlider.GetComponent<Slider>().value;
        Image.transform.localScale = new Vector3(sizeX , sizeY*size, sizeZ);

        Jefe.transform.localPosition = new Vector3(JefeX, JefeY * size, JefeZ);
        Gibus.transform.localPosition = new Vector3(GibusX, GibusY * size, GibusZ);
        WizzardHat.transform.localPosition = new Vector3(WizzardX, WizzardY * size, WizzardZ);
    }

}
