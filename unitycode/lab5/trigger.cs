using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // on pressing W set animation trigger  forward
        if (Input.GetKeyDown(KeyCode.W))
        {   
            Debug.Log("Forward");
            GetComponent<Animator>().SetTrigger("forward");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Backward");

            GetComponent<Animator>().SetTrigger("backward");
        }

    }
}
