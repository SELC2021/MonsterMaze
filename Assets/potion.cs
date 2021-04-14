using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion : MonoBehaviour
{
    public HealthBar healthBar; //added

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void clickedOnButton()
    {
        if (GlobalVariables.globalvars.potions > 0)
        {
            GlobalVariables.globalvars.playerHealth += 10;
            GlobalVariables.globalvars.potions -= 1;
            healthBar.SetHealth(GlobalVariables.globalvars.playerHealth);  //added
        }
    }
}
