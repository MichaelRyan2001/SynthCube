using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    private float speed = 15f;
    public bool gameOver = false;

    //Simple method used to increase the speed of the game objects
    void speedIncrease()
    {
        speed = speed + 3f;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Invoke repeating is used to perform a method over and over again with a delay time for the start
        //and when it can repeat
        InvokeRepeating("speedIncrease", 10f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        //If the game over boolean is false then the objects will move
        if (gameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        //Caps the speed increase at a certain point
        if (speed >= 50f)
        {
            //Cancel Invoke cancels the invoke repeating that we're using for the speed increase
            CancelInvoke("speedIncrease");
        }
    }
    //Simple public method which is used to stop objects moving
    public void stopMoving()
    {
        transform.Translate(0, 0, 0);
    }
}