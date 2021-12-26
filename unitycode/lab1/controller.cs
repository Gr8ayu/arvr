using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    

    void Update()
    {
        
        // move player horizontally and vertically
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);

    }
}

