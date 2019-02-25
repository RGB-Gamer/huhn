using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    	public Transform Player;
    	public Vector3 offset;
	public Transform fluegell;
	public Transform fluegelr;
	public  var float upforce = 500f;
	public  var float forward = 500f;
	public  var float sideforce = 500f;
	
	
    void Update () {
	    Debug.Log (fluegelr);
	    /*
	    if(fluegelr.y>0){
	    gam.AddForce(forward,upforce ,  sideforce) //ForceMode.VelocityChange
	    
	    }
	    if(fluegelr.y>0){
	    gam.AddForce(forward,upforce , -sideforce)// ForceMode.VelocityChange
	    
	    }
	    
	    */


        transform.position = Player.position ; 

	}
}
