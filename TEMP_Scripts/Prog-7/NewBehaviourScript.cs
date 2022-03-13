using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Light lit;
    // Start is called before the first frame update
    void Start()
    {
        lit = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Color c = new Color();
            c.r = 1f;
            c.a = 1f;

            lit.color = c;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Color c = new Color();
            c.g = 1f;
            c.a = 1f;

            lit.color = c;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Color c = new Color();
            c.b = 1f;
            c.a = 1f;

            lit.color = c;
        }

    }
}