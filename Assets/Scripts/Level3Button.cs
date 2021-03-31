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
<<<<<<< HEAD
=======
            GlobalVariables.globalvars.armorLevel = 1;
>>>>>>> 41aa107e5c3c61201fe2fe19aa41289a5ffec30e
            GlobalVariables.globalvars.enemyPower = 10;
        } else
        {
            Debug.Log("Complete Maze 2 to unlock");
        }
    }
}
