using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Adjust sensitivity in the Inspector
    public Transform playerBody; // Reference to the parent Player object

    float xRotation = 0f;

    void Start()
    {
        // Lock the cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse input and adjust by sensitivity and Time.deltaTime
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Calculate vertical rotation (looking up and down)
        xRotation -= mouseY;
        // Clamp the vertical rotation to prevent flipping the camera upside down
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Apply vertical rotation to the camera itself (local rotation)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Apply horizontal rotation (looking left and right) to the entire player body
        playerBody.Rotate(Vector3.up * mouseX);
    }
}


