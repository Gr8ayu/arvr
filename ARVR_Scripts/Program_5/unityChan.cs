using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityChan : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("run");
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("win");
        }
    }
}
