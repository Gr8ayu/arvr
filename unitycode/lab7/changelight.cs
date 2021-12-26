using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changelight : MonoBehaviour
{
    // Start is called before the first frame update
    public Light lights;
    bool lighton = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("tab")){
            lights.color = Color.red;
        }
        else{
            lights.color = Color.green;
        }
    }
}
