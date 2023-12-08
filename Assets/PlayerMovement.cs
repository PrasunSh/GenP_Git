using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float X = 100f;
    public float Z = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("s")){
            rb.AddForce(0,0,-Z*Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w")){
            rb.AddForce(0,0,Z*Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-X*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(X*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
