using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    bool slide;
    public Collider2D obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            //if (obstacle.tag == "slide")
            //{
            slide = true;
            obstacle.enabled = false;
            Debug.Log("Collider.enabled = " + obstacle.enabled);
            //}
            //gameObject.transform.Rotate(0, 0, 45, Space.Self);


        }
        else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            //gameObject.transform.Rotate(0, 0, -50, Space.Self);
            slide = false;
            obstacle.enabled = true;
        }
    }
}
