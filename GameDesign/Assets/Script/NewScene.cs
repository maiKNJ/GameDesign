using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("Cutscene3", LoadSceneMode.Single);
            }
        }
        
    }
}
