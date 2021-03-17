using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2Button : MonoBehaviour
{
    public void clickedOnButton()
    {
        SceneManager.LoadScene(sceneName: "Scene2");
        GlobalVariables.globalvars.playerHealth = 100;

    }
}
