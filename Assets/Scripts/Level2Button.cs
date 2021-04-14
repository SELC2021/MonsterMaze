﻿using System.Collections;
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

            GlobalVariables.globalvars.armorLevel = 1;
            GlobalVariables.globalvars.weaponLevel = 1;
            GlobalVariables.globalvars.enemyPower = 10;
        } else
        {
            Debug.Log("Complete Maze 1 to unlock");
        }
    }
}
