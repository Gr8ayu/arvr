using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);

                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * 100f);
                }

              
            }
        }
        
    }
}
