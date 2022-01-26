using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private Transform moveObject;

    [SerializeField] private Transform leftMaxShift;
    [SerializeField] private Transform rightMaxShift;

    public Vector2 startPos;
    public Vector2 direction;

    private void Update()
    {


        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.
                    startPos = touch.position;
                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    direction = touch.position - startPos;
                    direction *= Time.deltaTime;
                    if(moveObject.position.x < rightMaxShift.position.x && moveObject.position.x > leftMaxShift.position.x)
                    moveObject.position += new Vector3(direction.x, 0, 0);
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    break;
            }
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 startPos;

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 position = camera.ScreenToWorldPoint(touch.position);
                position -= camera.gameObject.transform.position;
                print((position));
                moveObject.position = new Vector3(touch.position.x * Time.deltaTime, moveObject.position.y,
                    moveObject.position.z);

                if( position.x < rightMaxShift.position.x && position.x > leftMaxShift.position.x)
                    moveObject.position = new Vector3(position.x,  moveObject.position.y, moveObject.position.z);
                transform.position = position;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.A))
            moveObject.gameObject.GetComponent<Move>().Left();
        if(Input.GetKeyDown(KeyCode.D))
            moveObject.gameObject.GetComponent<Move>().Right();

    }
}




  
