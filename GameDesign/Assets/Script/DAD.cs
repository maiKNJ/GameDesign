using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAD : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    float jumpSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            player.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpSpeed;
        }
        if (collision.gameObject.tag == "DAD")
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = true;
        }
    }
}
