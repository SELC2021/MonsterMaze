using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void clickedOnButton()
    {
        if (GlobalVariables.globalvars.moneyAmount >= GlobalVariables.globalvars.weaponLevel * 5)
        {
            GlobalVariables.globalvars.moneyAmount -= GlobalVariables.globalvars.weaponLevel * 5;
            GlobalVariables.globalvars.playerStrength += 50;
            GlobalVariables.globalvars.weaponLevel += 1;


        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }
}
