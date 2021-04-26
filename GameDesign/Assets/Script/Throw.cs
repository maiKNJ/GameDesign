using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    public GameObject stuff;
    public Rigidbody2D stuffR;
    float speed = -200f;
    int numR = 0;
    // Start is called before the first frame update
    void Start()
    {
        stuffR = stuff.transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numR <= 3)
        {
            /*Instantiate(stuff, transform.position, transform.rotation);
            stuffR = stuff.transform.GetComponent<Rigidbody2D>();
            stuffR.AddForce(stuff.transform.right * 20000, ForceMode2D.Impulse);
            //stuff.transform.position += Vector3.right * speed * Time.deltaTime;
            */
            Vector3 position = new Vector3(this.transform.position.x + 1, this.transform.position.y + 0.5f, this.transform.position.z);
            var projectile = Instantiate(stuff, position , this.transform.rotation);
            stuffR = projectile.GetComponent<Rigidbody2D>();
            stuffR.AddForce((float)speed * this.transform.right);
            numR++;

        }
    }

   


}
