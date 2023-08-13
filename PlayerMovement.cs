using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitMovement();
    }

    void LimitMovement()
    {
        if(transform.position.x> 2.6f)
        {
            transform.position = new Vector3(2.6f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -2.6f)
        {
            transform.position = new Vector3(-2.6f, transform.position.y, transform.position.z);
        }
    }
}
