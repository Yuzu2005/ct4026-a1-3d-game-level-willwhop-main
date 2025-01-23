using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour {
    //gets the cameras position
    public Transform cameraPosition;
    
    private void Update() {
        //allows for the camera to move with the player character
        transform.position = cameraPosition.position;
    }
}
