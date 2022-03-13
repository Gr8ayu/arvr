using UnityEngine;

public class ball : MonoBehaviour
{
    public float thrust = 600.0f;

    public void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * -thrust);

    }

}