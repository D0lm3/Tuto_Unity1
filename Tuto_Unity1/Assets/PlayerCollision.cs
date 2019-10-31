using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //add a component to manage the movement
   void OnCollisionEnter(Collision collisionInfo) { //we use it to add action on collision

       if(collisionInfo.collider.tag == "Obstacle"){ //if we collide with an object which as the obstacle tag then the follow happens

       Debug.Log("We hit an obstacle !");
       movement.enabled = false; //cancel the player movement

       }
    }
}
