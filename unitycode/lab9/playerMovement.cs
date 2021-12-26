using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHealth = 100f;
    public float currentHealth ;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(currentHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
       // increase health if right mouse button is pressed
         if (Input.GetMouseButtonDown(1))
         {
              Debug.Log("Right mouse button pressed");
                currentHealth = Mathf.Min(currentHealth + 10, maxHealth);
                healthBar.SetHealth(currentHealth);

         }

        // decrease health if left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse button pressed");
            currentHealth = Mathf.Max(currentHealth - 10, 0);

            healthBar.SetHealth(currentHealth);

        }

        // move player horizontally and vertically
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * 5);


        
    }
}
