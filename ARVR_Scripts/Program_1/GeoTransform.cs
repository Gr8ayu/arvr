using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoTransform : MonoBehaviour
{
    public float movement;

    
    // Start is called before the first frame update
    void Start()
    {
        movement = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement*Input.GetAxis("Horizontal")*Time.deltaTime,0f,movement*Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
