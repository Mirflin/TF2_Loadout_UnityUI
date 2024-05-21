using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolutionScript : MonoBehaviour
{
    Camera cam;
    void Awake()
    {
        cam = Camera.main;
        cam.orthographicSize = GetHeightProportion() * 5 / 56.25f; //1920x1080 reference ---
    }

    float GetHeightProportion()
    {
        return ((float)Screen.height * 100) / (float)Screen.width;
    }
}
