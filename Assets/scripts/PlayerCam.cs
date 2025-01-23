using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour {
    //sensx, y gets the input for both x and y sensitivity
    public float sensX;
    public float sensY;
    public Transform oriantion;
    //gets the input for the x and y rotation
    float xRotation;
    float yRotation;

    // at the start of opening the scene make the cursor locked and invisible
    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
   
    private void Update() {
        //get mouse rotation
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        //stops player from looking more than 90 degrees on the x rotation
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //applies rotatiom to the camera and direction of orientation in which the player will face
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        oriantion.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
