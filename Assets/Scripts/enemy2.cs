using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    private Vector2 target;
    private Vector2 position;
    int hitpoints = 2000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);
        if (distance < 10f)
        {
            position = gameObject.transform.position;
            target = GameObject.Find("Wizard Variant").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, target, .015f);
        }
    }
    private void OnMouseDown()
    {
        {
            if (hitpoints <= GlobalVariables.globalvars.playerStrength)
            {
                Destroy(gameObject);
                GlobalVariables.globalvars.moneyAmount += 10;
            }
            else
            {
                hitpoints -= GlobalVariables.globalvars.playerStrength;
            }
        }
    }
}
