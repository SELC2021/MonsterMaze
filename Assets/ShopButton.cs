﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void clickedOnButton()
    {

        SceneManager.LoadScene(sceneName: "Shop");
    }
}
