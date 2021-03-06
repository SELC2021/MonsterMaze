using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public float speed = 0.5f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;

    public HealthBar healthBar; //added

    public bool lookright = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        healthBar.SetMaxHealth(GlobalVariables.globalvars.playerHealth); //added

    }

    // Update is called once per frame
    void Update()
    {

        // Fliping
        if(rigidBody.velocity.x > 0 && !lookright || rigidBody.velocity.x <0 && lookright){
          Flip();
        }


        movement = Input.GetAxis("Horizontal");
        if(movement > 0f){
          rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        }
        else if(movement < 0f){
          rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        }
        else{
          rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }

        movement = Input.GetAxis("Vertical");
        if(movement > 0f){
          rigidBody.velocity = new Vector2(rigidBody.velocity.x, movement*speed);
        }
        else if(movement < 0f){
          rigidBody.velocity = new Vector2(rigidBody.velocity.x, movement*speed);
        }
        else{
          rigidBody.velocity = new Vector2(rigidBody.velocity.x, movement*speed);
        }
    }

    //hopefully flips the character
    void Flip(){
      lookright = !lookright;
      Vector3 charscale = transform.localScale;
      charscale.x *= -1;
      transform.localScale = charscale;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            if (GlobalVariables.globalvars.playerHealth <= 10)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(sceneName: "MainMenu");
                healthBar.SetHealth(0);  //added
            } else
            {
                GlobalVariables.globalvars.playerHealth -= 10;
                healthBar.SetHealth(GlobalVariables.globalvars.playerHealth);  //added
            }
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            if (GlobalVariables.globalvars.playerHealth <= 20)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(sceneName: "MainMenu");
                healthBar.SetHealth(0);  //added
            }
            else
            {
                GlobalVariables.globalvars.playerHealth -= 20;
                healthBar.SetHealth(GlobalVariables.globalvars.playerHealth);  //added
            }
        }
        if (collision.gameObject.tag == "End")
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }
}
