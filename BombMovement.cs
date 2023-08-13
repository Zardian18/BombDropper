using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    [SerializeField]
    float speed=2f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        CheckPosition();
    }

    void CheckPosition()
    {
        if (transform.position.y <-5)
        {
            Destroy(gameObject);
        }
    }
}
