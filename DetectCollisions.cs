using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //Private variables call other scripts
    private MoveObjects moveObjectScript;
    private ScoreManager scoreManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        //In the start method we need to find an object to use data from other scripts
        moveObjectScript = GameObject.Find("Cube(Clone)").GetComponent<MoveObjects>();
        moveObjectScript = GameObject.Find("Grid Plane").GetComponent<MoveObjects>();
        scoreManagerScript = GameObject.Find("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //This methods ensures that whatever is moving must stop when the game over boolean is true
        //This is done to get the grid plane to stop when the game over state is active 
        if(moveObjectScript.gameOver == true)
        {
            moveObjectScript.stopMoving();
        }
    }
    //Method used to detect collisions
    private void OnTriggerEnter(Collider other)
    {
        //If a game object with the cube tag enters the trigger it will destroy the player and change to game over
        if (gameObject.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
            moveObjectScript.gameOver = true;
        }
        //If a game object collides with a pickup then the pickup will be destroyed on collision and the score will go up.
        if(gameObject.CompareTag("PickUp"))
        {
            Destroy(gameObject);
            scoreManagerScript.Score();
        }
    }
}