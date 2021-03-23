using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float jumpSpeed = 6f;
    public float speed = 2f;
    bool slide;
    bool jump = true;
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
        
      
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) && jump == true || Input.GetKey(KeyCode.UpArrow) && jump == true)
        {
            //if (jump == true)
            //{
                rigidBody.velocity = Vector2.up * jumpSpeed;
                //rigidBody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
                jump = false;
            //body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //}

        }
        if (rigidBody.velocity.y == 0)
        {
            jump = true;
        }
       /* if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) )
        {
            //if (obstacle.tag == "slide")
            //{
                slide = true;
                obstacle.enabled = false;
                Debug.Log("Collider.enabled = " + obstacle.enabled);
            //}
            //gameObject.transform.Rotate(0, 0, 45, Space.Self);
            

        }
        else if(Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            //gameObject.transform.Rotate(0, 0, -50, Space.Self);
            slide = false;
            obstacle.enabled = true;
        }*/
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            jump = true;
        }
    }*/
}
