using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGridRoad : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatLength;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<BoxCollider>().size.z / 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        //Method used to repeat the grid to make it look like the player is moving forward
        if (transform.position.z > startPos.z + repeatLength)
        {
            transform.position = startPos;
        }
    }
}
