using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float jumpSpeed = 8f;
    public float speed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = transform.GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.velocity = Vector2.up * jumpSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) )
        {
            gameObject.transform.Rotate(0, 0, 45, Space.Self);
            
        }
        else if(Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(0, 0, -50, Space.Self);
        }
    }
}
