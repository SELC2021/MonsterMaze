using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2Button : MonoBehaviour
{
    public void clickedOnButton()
    {
        if (GlobalVariables.globalvars.level2 == true)
        {
            SceneManager.LoadScene(sceneName: "Scene2");
            GlobalVariables.globalvars.playerHealth = 100;
        } else
        {
            Debug.Log("Complete Maze 1 to unlock");
        }
    }
}
