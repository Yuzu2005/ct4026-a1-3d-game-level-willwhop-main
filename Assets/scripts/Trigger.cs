using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    //when the player enters the trigger they will be shown the menu scene
    void OnTriggerEnter(Collider player) {
        SceneManager.LoadScene("menu");
    }
}
