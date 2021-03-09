using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (SceneManager.GetActiveScene().name == "Start")
            {
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
            }
        }
    }
}
