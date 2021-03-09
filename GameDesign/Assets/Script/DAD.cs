using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DAD : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    float jumpSpeed = 10;
    float currentSpeed = 1f;
    private float minSpeed;
    float maxSpeed = 6f;
    private float time;
    public float accelerationTime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        minSpeed = currentSpeed;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
        transform.position += Vector3.right * currentSpeed * Time.deltaTime;
        time += Time.deltaTime;
        //transform.position += Vector3.right * speed * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }
        if (collision.gameObject.tag == "DAD" || collision.gameObject.tag == "slide")
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = true;
        }
    }
}
