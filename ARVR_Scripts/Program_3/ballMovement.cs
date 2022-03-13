using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrust = 600.0f;
    void Start()
    {
      GetComponent<Rigidbody2D>().AddForce(transform.right* -thrust);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
