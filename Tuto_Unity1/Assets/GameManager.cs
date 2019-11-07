using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; //use below to prevent the game to end multiple time (show GAME OVER ad nauseam)
  public void EndGame(){
      if(gameHasEnded == false){
      gameHasEnded = true; //prevent to end the game multiple time
       Debug.Log("Game Over");
       Invoke("Restart", 2f);
      }
   }

   void Restart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
  
}
