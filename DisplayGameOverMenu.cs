using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayGameOverMenu : MonoBehaviour
{
    private MoveObjects moveObjectScript;
    //Public game objects that can be attached in the hierarchy
    public GameObject gameOverMenu;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        moveObjectScript = GameObject.Find("Grid Plane").GetComponent<MoveObjects>();
    }

    // Update is called once per frame
    void Update()
    {
        //When the game over state is active the game over menu will appear in the game scree
        if (moveObjectScript.gameOver == true)
        {
            gameOverMenu.gameObject.SetActive(true);
        }
    }
}