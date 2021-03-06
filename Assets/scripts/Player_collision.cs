using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collision : MonoBehaviour
{
    public Rigidbody rocket;
    public Player_movement movement;
    public Player_movement movement2;
    //functie data de Unity care detecteaza  coliziunea dintre 2 chestii
    void OnCollisionEnter(Collision collisionInfo)
    {



        if (collisionInfo.collider.tag == "Obstacle")
        {
            float restartDelay = 1f;
            Debug.Log("We hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<Game_manager>().EndGame(restartDelay);
        }

        if (collisionInfo.collider.tag == "Pills")
        {
            rocket.AddForce(0, 15, 0, ForceMode.VelocityChange);
        }

        if (collisionInfo.collider.tag == "Bad_piil")
        {
            rocket.AddForce(0, 200, 0, ForceMode.VelocityChange);
        }
        if (collisionInfo.collider.tag == "Red_pill")
        {
            rocket.AddForce(30, 0, 0, ForceMode.VelocityChange);
        }
        if (collisionInfo.collider.tag == "Orange_pill")
        {
            rocket.AddForce(-30, 0, 0, ForceMode.VelocityChange);
        }
        if (collisionInfo.collider.tag == "Push_back")
        {
            rocket.AddForce(0, 10, -50, ForceMode.VelocityChange);
        }
        if (collisionInfo.collider.tag == "Yellow_pill")
        {
            rocket.AddForce(-40, 0, 0, ForceMode.VelocityChange);
        }

    }
}
