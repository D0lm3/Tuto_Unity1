using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player; // use to access the position (which can be found in the transform parameters) of the player
    public Text scoreText; // cause the name of the component responsible of the view of the score is Text

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
