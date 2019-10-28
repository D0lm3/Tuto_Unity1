
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb ; //We use rb for rigidbody (to save time)
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello WOrld!"); //A debug message to see how the console works
    }

    // Update is called once per frame
    void FixedUpdate() //We use FixedUpdate in place of Update cause we mess with physics
    {
        rb.AddForce(0, 0, 1000 * Time.deltaTime); //We had some force to rigidbody to create movement
    }
}
