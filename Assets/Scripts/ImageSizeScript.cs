using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ImageSizeScript : MonoBehaviour
{
    GameObject image;
    public void OnImage()
    {
        float size = 1.0f;
        for (int i = 0; i < 10; i++)
        {
            size = size + 0.1f;
            image.transform.localScale = new Vector2(1F * size, 1F * size);
        }
    }
    public void OfImage()
    {
        image.transform.localScale = new Vector2(1F * 1, 1F * 1);
    }

}
