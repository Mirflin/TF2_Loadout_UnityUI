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
    public void ToDemomanLoadout()
    {
        SceneManager.LoadScene("Loadout", LoadSceneMode.Single);
    }
    public void ToSniperLoadout()
    {
        SceneManager.LoadScene("Loadout_Sniper", LoadSceneMode.Single);
    }
    public void ToStartingScreen()
    {
        SceneManager.LoadScene("StartingScreen", LoadSceneMode.Single);
    }
}
