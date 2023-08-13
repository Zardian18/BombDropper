using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private bool tap, swipeLeft, swipeRight, isDragging;
    private Vector2 startTouch, swipeDelta;
    [SerializeField] float swipeMagnitude = 150f;

    
    void Update()
    {
        //tap = swipeLeft = swipeRight = false;
        tap = false;
        swipeLeft = false;
        swipeRight = false;
        PCInput();
        MobileInput();
        Swiping();
        Moving();
        Debug.Log(swipeDelta);
        //Debug.Log(swipeDelta.magnitude);

    }
    void ResetTouch() 
    { 
        startTouch= swipeDelta = Vector2.zero;
        isDragging = false;
    }
    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight { get { return swipeRight; } }

    void PCInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            isDragging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            ResetTouch();
        }
    }

    void MobileInput()
    {
        if (Input.touches.Length > 0)
        {
            if(Input.touches[0].phase== TouchPhase.Began)
            {
                tap = true;
                isDragging = true;
                startTouch = Input.touches[0].position;
            }
            else if(Input.touches[0].phase== TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDragging = false;
                ResetTouch();
            }
        }
    }

    void Swiping()
    {
        swipeDelta = Vector2.zero;
        if (isDragging)
        {
            if (Input.touches.Length > 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }
    }

    void Moving()
    {
        if (swipeDelta.magnitude > swipeMagnitude)
        {
            float x = swipeDelta.x;
            //float y = swipeDelta.y;

            //if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x > 0)
                {
                    swipeRight = true;
                    swipeLeft = false;
                }
                else
                {
                    swipeLeft = true;
                    swipeRight = false;
                }
            }
        }
    }
}
