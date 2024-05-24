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
    public GameObject PrefabSpot;
    private Vector3 position = new Vector3(0,0,-24);
    

    public void OnButtonClick(Button button)
    {
        PrefabSpot.SetActive(true);
        Object[] allObjects = FindObjectsOfType(typeof(GameObject));
        foreach (GameObject obj in allObjects)
        {
            if (obj.transform.name == "SpawnSpot(Clone)")
            {
                Destroy(obj);
            }
        }
   
        string name = button.name;
        GameObject newPrefab = Instantiate(imageHolder, position, imageHolder.transform.rotation) as GameObject;
        newPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("prefabHat").transform, false);
        if (name == "jefeButton")
        {
            imageHolder.GetComponent<Image>().sprite = jefe;
        }else if (name == "gibbusButton")
        {
            imageHolder.GetComponent<Image>().sprite = gibus;
        }
        else
        {
            imageHolder.GetComponent<Image>().sprite = wizzardsHat;
        }
    }

}
