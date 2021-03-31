using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2lock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.globalvars.level2 == true)
        {
            gameObject.SetActive(false);
        }
    }
}
