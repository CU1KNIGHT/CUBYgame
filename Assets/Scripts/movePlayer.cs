using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();// instance of function
                                       //  Debug.Log("Hello, World!");
                                       //  rb.AddForce(0, 200, 200);
    }

    // Update is called once per frame
    void FixedUpdate()
    {//add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
 
