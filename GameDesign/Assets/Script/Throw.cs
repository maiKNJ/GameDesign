using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    public GameObject stuff;
    public Rigidbody2D stuffR;
    float speed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        stuffR = stuff.transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*Instantiate(stuff, transform.position, transform.rotation);
            stuffR = stuff.transform.GetComponent<Rigidbody2D>();
            stuffR.AddForce(stuff.transform.right * 20000, ForceMode2D.Impulse);
            //stuff.transform.position += Vector3.right * speed * Time.deltaTime;
            */
            var projectile = Instantiate(stuff, this.transform.position, this.transform.rotation);
            stuffR = projectile.GetComponent<Rigidbody2D>();
            stuffR.AddForce((float)speed * this.transform.right);

        }
    }

   


}
