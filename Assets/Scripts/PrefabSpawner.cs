using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.FilePathAttribute;


public class PrefabSpawner : MonoBehaviour
{
    public GameObject imageHolder;
    public Sprite jefe;
    public Sprite gibus;
    public Sprite wizzardsHat;
    private Vector2 position = new Vector2(817,676);

    public void OnButtonClick(Button button)
    {
        string name = button.name;
        Debug.Log(name);
        Instantiate(imageHolder, position, imageHolder.transform.rotation);
        if (name == "jefeButton")
        {
            Debug.Log("JEFE");
            imageHolder.GetComponent<Image>().sprite = jefe;
        }else if (name == "gibbusButton")
        {
            Debug.Log("GIBBUS");
            imageHolder.GetComponent<Image>().sprite = gibus;
        }
        else
        {
            Debug.Log("WIZZARD");
            imageHolder.GetComponent<Image>().sprite = wizzardsHat;
        }
    }

}
