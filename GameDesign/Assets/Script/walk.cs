using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class walk : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public Animator animator;
    public float jumpSpeed = 6f;
    public float speed = 2f;
    bool slide;
    bool jump = true;
    bool forward = false;
    bool jump2 = false;
    //public Collider2D obstacle;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = transform.GetComponent<Rigidbody2D>();
        //obstacle = obstacle.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //level 2
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                forward = true;
                transform.position += Vector3.right * speed * Time.deltaTime;
                animator.SetBool("speed", forward);
            }
            else
            {
                forward = false;
                animator.SetBool("speed", forward);

            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                forward = false;
                slide = true;
                animator.SetBool("speed", forward);
                animator.SetBool("slide", slide);
            }
            else
            {
                slide = false;
                animator.SetBool("slide", slide);
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                forward = false;
                jump2 = true;
                animator.SetBool("speed", forward);
                animator.SetBool("jump", jump2);

            }
            else
            {
                jump2 = false;
                animator.SetBool("jump", jump2);
            }
        }

        //level 4
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                forward = true;
                transform.position += Vector3.left * speed * Time.deltaTime;
                animator.SetBool("speed", forward);
            }
            else
            {
                forward = false;
                animator.SetBool("speed", forward);

            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                forward = false;
                slide = true;
                animator.SetBool("speed", forward);
                animator.SetBool("slide", slide);
            }
            else
            {
                slide = false;
                animator.SetBool("slide", slide);
            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                forward = false;
                jump2 = true;
                animator.SetBool("speed", forward);
                animator.SetBool("jump", jump2);

            }
            else
            {
                jump2 = false;
                animator.SetBool("jump", jump2);
            }
        }
        //jump all levels

        if (Input.GetKey(KeyCode.W) && jump == true)
        {
            rigidBody.velocity = Vector2.up * jumpSpeed;
            jump = false;

        }
      
        if (rigidBody.velocity.y == 0)
        {
            jump = true;
        }
    }
}
