using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayMovement : MonoBehaviour
{
    public float rotationSpeed = 20f;
    private Vector3 horizontalMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));

        transform.Rotate(horizontalMovement * rotationSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Space))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 100f, Color.red);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 100f);

            if(hit)
            {
                hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}
