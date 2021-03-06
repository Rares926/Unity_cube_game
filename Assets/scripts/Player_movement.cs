using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Rigidbody rb;
    [Range(1, 5000)]
    public float ForwardForce = 2000;
    [Range(1, 1000)]
    public float SidewaysForce = 500;

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-0.5f)
        {
            float restartDelay = 0.2f;
            FindObjectOfType<Game_manager>().EndGame(restartDelay);
        }
        if(rb.position.y>50f)
        {
            float restartDelay = 0.5f;
            FindObjectOfType<Game_manager>().EndGame(restartDelay);
        }
    }
}
