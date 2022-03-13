using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rbody;
    private Renderer rend;
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 300f;
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        float moveX = inputX * moveSpeed * Time.deltaTime;
        float moveZ = inputZ * moveSpeed * Time.deltaTime;

        rbody.AddForce(moveX,0f,moveZ);
       
    }

    void OnCollisionEnter(Collision col)
    {
        print(col.transform.tag);
        if(col.collider.name == "Wall_1")
        {
            rend.material.color = Color.blue;
            myLight.color = Color.blue;
        }
        else if(col.collider.name == "Wall_2")
        {
            rend.material.color = Color.green;
            myLight.color = Color.green;
        }
        else if(col.collider.name == "Wall_3")
        {
            rend.material.color = Color.red;
            myLight.color = Color.red;
        }
        else if(col.collider.name == "Wall_4"){
            rend.material.color = Color.yellow;
            myLight.color = Color.yellow;
        }

    }
}
