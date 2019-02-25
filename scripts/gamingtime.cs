
using UnityEngine;

public class gamingtime : MonoBehaviour {

    public Rigidbody gam;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private bool jump;
    private bool a;

    /// <summary>
    /// Gamingtime
    /// </summary>

    // Update is called once per frame

    void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.name == "Gamingtime")
        {
            a = true;
        }
    }


    private void Update()
    {
      
       if (Input.GetKey("w") & a)
        {
            jump = true;
            a = false;
        }


       

     
    }


    void FixedUpdate () {
        gam.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            gam.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            gam.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (jump)
        {
          gam.AddForce(0, 1000, 0);
            jump = false;
        }
    }
}
