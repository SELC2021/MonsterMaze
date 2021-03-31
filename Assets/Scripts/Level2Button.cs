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
            GlobalVariables.globalvars.moneyAmount = 0;
<<<<<<< HEAD
=======
            GlobalVariables.globalvars.armorLevel = 1;
>>>>>>> 41aa107e5c3c61201fe2fe19aa41289a5ffec30e
            GlobalVariables.globalvars.enemyPower = 10;
        } else
        {
            Debug.Log("Complete Maze 1 to unlock");
        }
    }
}
