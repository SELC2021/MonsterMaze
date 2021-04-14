using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            GlobalVariables.globalvars.gemAmount -= 5;
            GlobalVariables.globalvars.potions += 1;
      }
      else{
            Debug.Log("Not Enough Money");
      }
    }
}
