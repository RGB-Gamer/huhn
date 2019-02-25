using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {


    public gamingtime movement;

	// Use this for initialization
 void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }

}