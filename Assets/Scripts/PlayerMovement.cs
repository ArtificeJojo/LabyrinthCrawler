using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveVal = 0.01f;
    public Camera cam;
    // Update is called once per frame
    void Update()
    {
        UpDown();
        LeftRight();
        //MoveDiagonal();
    }

    void UpDown()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            moveVal = 0.05f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, moveVal);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -moveVal);
        }
    }

    void LeftRight()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            moveVal = 0.05f;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveVal, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveVal, 0, 0);
        }
    }
    /*
    void MoveDiagonal()
    {
        
        if (Input.GetKey(KeyCode.Q))
                transform.Translate(-moveVal, 0, moveVal);

        if (Input.GetKey(KeyCode.E))
                transform.Translate(moveVal, 0, moveVal);

        if (Input.GetKey(KeyCode.Z))
                transform.Translate(-moveVal, 0, -moveVal);

        if (Input.GetKey(KeyCode.C))
                transform.Translate(moveVal, 0, -moveVal);
        
    }
    */
    
}
