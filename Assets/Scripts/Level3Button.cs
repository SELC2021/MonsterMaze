using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Button : MonoBehaviour
{
    public void clickedOnButton()
    {
        if (GlobalVariables.globalvars.level3 == true)
        {
            Debug.Log("Replace with however you get to Scene 3");
            GlobalVariables.globalvars.playerHealth = 100;
            GlobalVariables.globalvars.moneyAmount = 0;
            GlobalVariables.globalvars.armorLevel = 1;
            GlobalVariables.globalvars.enemyPower = 10;
        } else
        {
            Debug.Log("Complete Maze 2 to unlock");
        }
    }
}
