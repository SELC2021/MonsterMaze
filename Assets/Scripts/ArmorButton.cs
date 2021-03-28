using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void clickedOnButton()
    {
        if (GlobalVariables.globalvars.moneyAmount >= GlobalVariables.globalvars.armorLevel * 10)
        {
            GlobalVariables.globalvars.moneyAmount -= GlobalVariables.globalvars.armorLevel * 10;
            //GlobalVariables.globalvars.playerHealth += 1;
            if(GlobalVariables.globalvars.enemyPower > 1){
              GlobalVariables.globalvars.enemyPower -= 1;
            }
            GlobalVariables.globalvars.armorLevel += 1;

        } else
        {
            Debug.Log("Not Enough Money");
        }
    }
}
