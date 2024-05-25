using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InpuScript : MonoBehaviour
{
    string text = "";
    string age = "";
    public GameObject inputField;
    public GameObject inputFieldAge;
    public GameObject displayField;
    string[] words = {"Hello", "Nice to meet you"};
    int randnum;

    public void getText()
    {
        randnum = Random.Range(0, words.Length);
        age = inputFieldAge.GetComponent<Text>().text;
        text = inputField.GetComponent<Text>().text;
        Debug.Log(text+" "+ age);
        displayField.GetComponent<Text>().text = words[randnum] + " " + text.ToLower() + "\n "+ "Your age is "+age;
    }
}
