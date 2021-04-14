using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    private Vector2 target;
    private Vector2 position;
    int hitpoints = 10000;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
      StartCoroutine(cookieDeath());
    }

    // Update is called once per frame
    void Update()
    {

          float distance = Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position);
          if (distance < 8f)
          {
              position = gameObject.transform.position;
              target = GameObject.Find("Wizard Variant").transform.position; //needs to say "Wizard Variant" to follow wizard girl
              transform.position = Vector2.MoveTowards(transform.position, target, 1f);
          }


    }
    private void OnMouseDown()
    {
        {
            if (hitpoints <= GlobalVariables.globalvars.playerStrength)
            {
                cookieDeath();
                Destroy(gameObject);
                GlobalVariables.globalvars.moneyAmount += 5;
            }
            else
            {
                hitpoints -= GlobalVariables.globalvars.playerStrength;
            }
        }
    }

    IEnumerator cookieDeath()
    {
      anim.SetTrigger("cookieboydeath");
      yield return new WaitForSeconds(2);
    }
}
