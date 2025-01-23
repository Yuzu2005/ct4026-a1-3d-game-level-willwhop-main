using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    void Awake() {
        //make the cursor visible on the main menu screen
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void PlayGame() {
        //loads the parkour level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToOptions() {
        //checks for the scene called options and opens it
        SceneManager.LoadScene("Options");
    }

    public void update() {
        //for every frame check to see which resolution is being used
        SetScreenRes();
    }

    public void GoToSecret() {
        SceneManager.LoadScene("Secret");
    }

    public void GoToMenu() {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame() {
        //quits the game
        Application.Quit();
    }

    void SetScreenRes() {
        //gets the name of the button pressed and changes the screen resolution the the ones in brackets
        string Index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        switch (Index) {
            case "screenResOp1":
            Screen.SetResolution(1152, 648, true);
            break;
            case "screenResOp2":
            Screen.SetResolution(1280, 720, true);
            break;
            case "screenResOp3":
            Screen.SetResolution(1920, 1080, true);
            break;
            case "screenResOp4":
            Screen.SetResolution(2560, 1440, true);
            break;
            case "screenResOp5":
            Screen.SetResolution(3840, 2160, true);
            break;

        }
    }
}
