using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.blue;

    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("tab") || Input.GetMouseButtonDown(0) )
        {
           float t = Mathf.PingPong(Time.time, duration) / duration;
           light.color = Color.Lerp(color0, color1, t);
        }
        
    }
}
