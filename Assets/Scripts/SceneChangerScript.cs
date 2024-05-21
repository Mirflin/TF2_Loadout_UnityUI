using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour
{
    public void ToChangeLoadoutScene()
    {
        SceneManager.LoadScene("ChooseLoadoutCharacter", LoadSceneMode.Single);
    }
}
