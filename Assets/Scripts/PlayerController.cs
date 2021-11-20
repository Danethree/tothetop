using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private Vector2 startTouchPosition, currentTouchPosition, endTouchPosition;
    private bool stopTouch = false;
    public float swipeRange,tapRange,speed;
    private GameObject player;
    
    // Update is called once per frame
    private void Start()
    {
        player = GetComponent<GameObject>();
    }
    void Update()
    {
      
    }

   
    public void Swipe()
    {
       if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }
        #region PlayerIsTouching

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentTouchPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentTouchPosition - startTouchPosition;

            if (!stopTouch)
            {
                if (Distance.x < -swipeRange)
                {
                    player.transform.position = Vector2.left*speed*Time.deltaTime;
                    stopTouch = true;
                }
                else if (Distance.x < swipeRange)
                {
                    player.transform.position = Vector2.right*speed*Time.deltaTime;
                    stopTouch = true;
                }


            }
        }
        #endregion
        #region PlayerStopTouch

            if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;
            endTouchPosition = Input.GetTouch(0).position;
            Vector2 Distance = endTouchPosition - startTouchPosition;
            if(Mathf.Abs(Distance.x)< tapRange)
            {
                //STOPTOUCH
            }
        }

        #endregion


    }
}
