using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckmarkScript : MonoBehaviour
{
    public GameObject Hats;
    public Toggle m_toggle;
    public void Check()
    {
        if (m_toggle.isOn)
        {
            Hats.SetActive(true);
        }
        else
        {
            Hats.SetActive(false);
        }
    }
}
