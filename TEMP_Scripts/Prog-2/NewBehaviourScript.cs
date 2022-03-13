using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     public float force = .5f;
public Rigidbody rbody;
private  Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
rbody = GetComponent<Rigidbody>();
rend = GetComponent<Renderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        float inputx=Input.GetAxis("Horizontal");
        float inputz =Input.GetAxis("Vertical");
        float movex= inputx *force ;
float movez = inputz * force;
rbody.AddForce(movex, 0f, movez);
    }
void OnCollisionEnter(Collision col){
if(col.collider.name=="left"){
rend.material.color=Color.blue;
}
if(col.collider.name=="right"){
rend.material.color=Color.green;
}
if(col.collider.name=="front"){
rend.material.color=Color.red;
}
if(col.collider.name=="back"){
rend.material.color=Color.yellow;
}
}
}