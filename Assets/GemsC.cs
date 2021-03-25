using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "Player")
      {
            Destroy(gameObject);
            GlobalVariables.globalvars.gemAmount++;
      }

      if (collision.gameObject.tag == "Wizard Variant")
      {
            Destroy(gameObject);
            GlobalVariables.globalvars.gemAmount++;
      }

    }
}
