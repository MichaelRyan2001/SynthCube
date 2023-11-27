using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private float lowerBounds = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If any object breaches its bounds then that object will be destroyed
        //This is used for the pickups and the cube clones
        if (transform.position.z > lowerBounds)
        {
            Destroy(gameObject);
        }
    }
}