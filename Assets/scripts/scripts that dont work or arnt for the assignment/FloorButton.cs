using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloorButton : MonoBehaviour
{
    //check for the tag called "player"
    const string PLAYER_TAG = "Player";

    // set events to happen when button is either pressed or released

    public UnityEvent ButtonPressed;
    public UnityEvent ButtonReleased;

    //check if the thing being effected has been hit
    private void OnTriggerEnter(Collider other)
    {
        //if the other collider is player then message button pressed into the debug log
        if(other.CompareTag (PLAYER_TAG))
        {
            
            Debug.Log("Button Pressed");
            ButtonPressed.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if the other collider is player then message button pressed into the debug log
        if (other.CompareTag (PLAYER_TAG ))
        {
            
            Debug.Log("Button Released");
            ButtonReleased.Invoke();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
