using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    private float speed = 10f;
    private float jumpForce = 8f;
    private float gravity = 30f;
    private Vector3 moveDir = Vector3.zero;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = gameObject.GetComponent<CharacterController>();
            jumpForce =  right.velocity.y * 10;

     /*   moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
         moveDir = transform.TransformDirection(moveDir);
         moveDir *= speed; */
         moveDir.y = jumpForce;


        

         moveDir.y -= gravity * Time.deltaTime;
         jumpForce = 0;
         controller.Move(moveDir * Time.deltaTime);
    }
}
