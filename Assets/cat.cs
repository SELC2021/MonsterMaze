using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private Vector2 target;
    private Vector2 position;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = gameObject.transform.position;

        float distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);

            target = GameObject.Find("Wizard Variant").transform.position; //needs to say "Wizard Variant" to follow wizard girl
        if (distance < 8f)
        {
          if(distance > 2f){
                transform.position = Vector2.MoveTowards(transform.position, target, .01f);
          }
        }
    }
}
