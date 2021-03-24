using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{

    public float movePower = 10f;
    public float jumpPower = 15f;

    private Rigidbody2D rb;
    private Animator anim;
    Vector3 movement;
    private int direction = 1;
    bool isJumping = false;
    private bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        Restart();
        if (alive)
        {
            Hurt();
            Die();
            Attack();
            Run();

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("isJump", false);
    }

    // wizard stuff

    void Run()
    {
        Vector3 moveVelocity = Vector3.zero;
        anim.SetBool("isRun", false);


        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            direction = -1;
            moveVelocity = Vector3.left;

            transform.localScale = new Vector3(direction * .5f, .5f, 1);
            if (!anim.GetBool("isJump"))
                anim.SetBool("isRun", true);

        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            direction = 1;
            moveVelocity = Vector3.right;

            transform.localScale = new Vector3(direction * .5f, .5f, 1);
            if (!anim.GetBool("isJump"))
                anim.SetBool("isRun", true);

        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {

          moveVelocity = Vector3.up;

          //transform.localScale = new Vector3(.5f, direction * .5f, 1);
          if (!anim.GetBool("isJump"))
              anim.SetBool("isRun", true);

        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {

          moveVelocity = Vector3.down;

          //transform.localScale = new Vector3(.5f, -(direction * .5f), 1);
          if (!anim.GetBool("isJump"))
              anim.SetBool("isRun", true);

        }


        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("attack");
        }
    }

    void Hurt()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetTrigger("hurt");
            if (direction == 1)
                rb.AddForce(new Vector2(-5f, 1f), ForceMode2D.Impulse);
            else
                rb.AddForce(new Vector2(5f, 1f), ForceMode2D.Impulse);
        }
    }

    void Die()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetTrigger("die");
            alive = false;
        }
    }

    void Restart()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            anim.SetTrigger("idle");
            alive = true;
        }
    }

    //og playercontrol

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            if (GlobalVariables.globalvars.playerHealth <= 10)
            {
                Destroy(gameObject);
            } else
            {
                GlobalVariables.globalvars.playerHealth -= 10;
            }
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            if (GlobalVariables.globalvars.playerHealth <= 20)
            {
                Destroy(gameObject);
            }
            else
            {
                GlobalVariables.globalvars.playerHealth -= 20;
            }
        }
    }
}
