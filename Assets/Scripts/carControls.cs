using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class carControls : MonoBehaviour
{
    public float controlSpeed;
    private Vector2 currentPosition = new Vector2(0, -4);
    public float maxRightPosition = 1.35f;
    public float maxLeftPosition = -1.4f;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //currentPosition.x += -controlSpeed;
            currentPosition.x = currentPosition.x - controlSpeed;

            //currentPosition.x = Mathf.Clamp(currentPosition.x, maxLeftPosition, maxRightPosition);
           
            transform.position = new Vector3(currentPosition.x - controlSpeed, currentPosition.y, 0);
            

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //currentPosition.x += controlSpeed;
            currentPosition.x = currentPosition.x + controlSpeed;

            //currentPosition.x = Mathf.Clamp(currentPosition.x, maxLeftPosition, maxRightPosition);

            transform.position = new Vector3(currentPosition.x + controlSpeed, currentPosition.y, 0);
            
        }
    }

        
    
}
