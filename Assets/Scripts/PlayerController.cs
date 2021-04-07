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

        Debug.Log("player health: " + GlobalVariables.globalvars.playerHealth); //TEST



    }

    // Update is called once per frame
    void Update()
    {

        // Flipping
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
      // collision with enemy1
        if (collision.gameObject.tag == "Enemy1")
        {
            if (GlobalVariables.globalvars.playerHealth <= 0)
            {
                Destroy(gameObject);
                healthBar.SetHealth(0);  //added
                SceneManager.LoadScene(sceneName: "MainMenu");
            } else
            {
                GlobalVariables.globalvars.playerHealth = GlobalVariables.globalvars.playerHealth - GlobalVariables.globalvars.enemyPower; //TEST
                healthBar.SetHealth(GlobalVariables.globalvars.playerHealth);  //added
                Debug.Log("player health: " + GlobalVariables.globalvars.playerHealth); //TEST
                Debug.Log("Enemy power: " + GlobalVariables.globalvars.enemyPower); //TEST
            }
        }

        // collision with enemy 2
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
                GlobalVariables.globalvars.playerHealth -= (GlobalVariables.globalvars.enemyPower * 2);
                healthBar.SetHealth(GlobalVariables.globalvars.playerHealth);  //added
                Debug.Log("player health: " + GlobalVariables.globalvars.playerHealth); //TEST
                Debug.Log("Enemy power: " + GlobalVariables.globalvars.enemyPower); //TEST
            }
        }

        // Portal Home
        if (collision.gameObject.tag == "End")
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
            GlobalVariables.globalvars.level2 = true;
        }

        if (collision.gameObject.tag == "End2")
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
            GlobalVariables.globalvars.level3 = true;
        }
        if (collision.gameObject.tag == "End3")
        {
            SceneManager.LoadScene(sceneName: "cake");
        }
    }
}
