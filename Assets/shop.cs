using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject Canvas;
    bool shopOn = false;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (shopOn == true)
            {
                Canvas.SetActive(false);
                Debug.Log("off");
                shopOn = false;
            }
            else
            {
                Canvas.SetActive(true);
                Debug.Log("on");
                shopOn = true;
            }
        }
    }
}
