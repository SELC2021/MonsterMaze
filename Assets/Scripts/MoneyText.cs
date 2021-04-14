using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
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
        int gems = GlobalVariables.globalvars.newGems + GlobalVariables.globalvars.gemAmount;
        SetText("Money: $" + GlobalVariables.globalvars.moneyAmount + "  Gems: " + gems + "  Potions: " + GlobalVariables.globalvars.potions);
    }
}
