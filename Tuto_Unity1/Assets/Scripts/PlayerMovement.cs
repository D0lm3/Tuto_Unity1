
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb ; //We use rb for rigidbody (to save time)
    public float forwardForce = 3000f; //we put 3000 and 50 because we use a drag of 1 in the player window
    public float sidewaysForce = 50f;

    
    void Start()
    {
        Debug.Log("Hello World!"); //A debug message to see how the console works to show messages
    }

    
    void FixedUpdate() //We use FixedUpdate in place of Update cause we mess with physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //We had a forward force to rigidbody to create movement

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if( Input.GetKey("q"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
