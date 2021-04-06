using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DAD : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    public GameObject stuff;
    float jumpSpeed = 10;
    float currentSpeed = 1f;
    private float minSpeed;
    float maxSpeed = 4f;
    private float time;
    public float accelerationTime = 60f;
    bool animation = false;
    bool freeze = false;
    float seconds;
    public Animator animator;
    //AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        minSpeed = currentSpeed;
        time = 0;
        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
            transform.position += Vector3.right * currentSpeed * Time.deltaTime;
            time += Time.deltaTime;
            animation = false;
            animator.SetBool("idle", animation);
        }
        else if (SceneManager.GetActiveScene().name == "Level4" && freeze == false)
        {
            animation = false;
            animator.SetBool("idle", animation);
            currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
            transform.position += Vector3.left * (currentSpeed + 0.25f) * Time.deltaTime;
            
            time += Time.deltaTime;
            /*if (audio != null)
            {
                audio.Play();
            }*/
            
            
            
        }
       // Debug.Log("freeze" + freeze);

        if (freeze == true)
        {
            /*seconds = (int)Time.time % 60;
            Debug.Log("time: " + seconds);
            if (seconds > seconds + 2)
            {
                freeze = false;
                
            }*/
            StartCoroutine(enumerator(2));
            //enumerator(2);
        }
        
        //transform.position += Vector3.right * speed * Time.deltaTime;

    }

    IEnumerator enumerator(float time)
    {
        animation = true;
        animator.SetBool("idle", animation);
        Debug.Log("time start: " + Time.time);
        yield return new WaitForSeconds(time);
        Debug.Log("time end: " + Time.time);
        /*if (audio != null)
        {
            audio.Pause();
        }*/
        
        freeze = false;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            if (SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level4")
            {
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }

        if (collision.gameObject.tag == "throw")
        {
            freeze = true;
            Debug.Log("Freeze now");
        }

        if (collision.gameObject.tag == "DAD" || collision.gameObject.tag == "slide")
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            collision.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
        else
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = true;
            collision.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }

       
    }
}
