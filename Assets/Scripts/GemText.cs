using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemText : MonoBehaviour
{
    public Text textfield;

    public void SetText(string text)
    {
        textfield.text = text;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetText("Gems: " + GlobalVariables.globalvars.gemAmount);
    }
}
