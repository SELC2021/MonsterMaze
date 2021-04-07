using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown(){
      if(GlobalVariables.globalvars.gemAmount >= 5){
            Debug.Log("Gem amount: " + GlobalVariables.globalvars.gemAmount + " Potions: " + GlobalVariables.globalvars.potions); //test print statement
            GlobalVariables.globalvars.gemAmount -= 5;
            GlobalVariables.globalvars.potions += 1;
            Debug.Log("Gem amount: " + GlobalVariables.globalvars.gemAmount + " Potions: " + GlobalVariables.globalvars.potions); //test print statement
      }
      else{
            Debug.Log("Not Enough Money");
      }
    }
}
