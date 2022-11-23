using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Player;
    public float Velocity;
    public string LeftMovementKey;
    public string RightMovementKey;
    //public bool PlayerIsAlive; - implement this later

  
    void Update()
    { 
        Movement();
    }


    // Handles Player Movement - may need more refining.
    void Movement()
    {
        // Constantly Moves Player Forward
        Player.AddForce(0, 0, Velocity, ForceMode.Force);

        if (Input.GetKey(LeftMovementKey))
        {
            // Moves Player to the Left
            Player.AddForce(Velocity, 0, 0, ForceMode.Force);
        }
        else if (Input.GetKey(RightMovementKey))
        {
            // Moves Player to the Right
            Player.AddForce(-Velocity, 0, 0, ForceMode.Force);
        }
    }
}
