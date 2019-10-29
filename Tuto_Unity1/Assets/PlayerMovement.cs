
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb ; //We use rb for rigidbody (to save time)
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    
    void Start()
    {
        Debug.Log("Hello World!"); //A debug message to see how the console works to show messages
    }

    
    void FixedUpdate() //We use FixedUpdate in place of Update cause we mess with physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //We had a forward force to rigidbody to create movement

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if( Input.GetKey("q"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
