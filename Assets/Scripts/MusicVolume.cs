using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    public GameObject slider;
    public AudioSource audio;

    public void ChangeVolume()
    {
        float volume = slider.GetComponent<Slider>().value;
        audio.GetComponent<AudioSource>().volume = volume;
    }
}
