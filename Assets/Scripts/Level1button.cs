using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1button : MonoBehaviour
{
    public void clickedOnButton()
    {

        SceneManager.LoadScene(sceneName: "Maze1");
        GlobalVariables.globalvars.playerHealth = 100;

    }
}