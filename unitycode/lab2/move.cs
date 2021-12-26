using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    void Start()
    {
        // GetComponent<Rigidbody>().AddForce(transform.forward * speed*1000);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*horizontal*speed);
        transform.Translate(Vector3.right*vertical*speed);
    }

     private void OnCollisionEnter(Collision other) {
         if (other.collider.name == "red") {
            GetComponent<Renderer>().material.color = Color.red;             
         }
         if (other.collider.name == "blue") {
            GetComponent<Renderer>().material.color = Color.blue;             
         }
         if (other.collider.name == "green") {
            GetComponent<Renderer>().material.color = Color.green;             
         }
         if (other.collider.name == "yellow") {
            GetComponent<Renderer>().material.color = Color.yellow;             
         }
        if (other.collider.name == "white") {
            GetComponent<Renderer>().material.color = Color.white;             
        }
    }
}
