using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControls : MonoBehaviour
{
    [SerializeField]
    Swipe swipeControls;
    [SerializeField]
    Transform player;
    private Vector3 desiredPosition;
    [SerializeField]
    float swipeSpeed=2f;

   
    void Update()
    {
        if (Input.GetMouseButton(0)|| Input.touches.Length>0)
        {
            Movement();
        }
        else
        {
            desiredPosition = new Vector3(player.transform.position.x, -4, 0);
        }
    }

    void Movement()
    {
        if (swipeControls.SwipeLeft)
        {
            desiredPosition += Vector3.left;
        }
        else if (swipeControls.SwipeRight)
        {
            desiredPosition += Vector3.right;
        }

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, swipeSpeed * Time.deltaTime);
    }
}
