using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    // Mouse Sens for X and Y axis
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;
    void Start()
    {
        //Cursor to center of screen
        Cursor.lockState = CursorLockMode.Locked;
        //Hides Cursor
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse Input - Horiztonal and Vertical Mouse movements
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        //Rotate Camera left and right
        yRotation += mouseX;

        //Rotates Camera Up and Down
        xRotation += mouseY;
        //Prevents Camera from flipping over
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //rotation for cam and player orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
