using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveVal = 0.01f;
    public Camera cam;
    public bool isMoving = false;
    public GameObject player;
    // Update is called once per frame
    public void Update()
    {
        UpDown();
        LeftRight();
        MoveDiagonal();
    }

    public void Disable()
    {
        moveVal = 0;
    }

    public void Enable()
    {
        moveVal = 0.01f;
    }

    void UpDown()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            moveVal = 0.05f;
        
        
        

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, moveVal);
            player.transform.eulerAngles = new Vector3(0, 180, 0);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -moveVal);
            //player.transform.Rotate(0, 180, 0);
            player.transform.eulerAngles = new Vector3(0, 0, 0);
            isMoving = true;
        }
    }

    void LeftRight()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            moveVal = 0.05f;
        

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveVal, 0, 0);
            //player.transform.Rotate(0, 90, 0);
            player.transform.eulerAngles = new Vector3(0, -90, 0);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveVal, 0, 0);
            //player.transform.Rotate(0, -90, 0);
            player.transform.eulerAngles = new Vector3(0, 90, 0);
            isMoving = true;
        }
    }
    
    void MoveDiagonal()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-moveVal, 0, moveVal);
            player.transform.eulerAngles = new Vector3(0, 135, 0);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(moveVal, 0, moveVal);
            player.transform.eulerAngles = new Vector3(0, -135, 0);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(-moveVal, 0, -moveVal);
            player.transform.eulerAngles = new Vector3(0, 45, 0);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(moveVal, 0, -moveVal);
            player.transform.eulerAngles = new Vector3(0, -45, 0);
            isMoving = true;
        }
        
    }
   
    
}
