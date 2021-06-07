using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public Canvas pauseCanvas;
    public Button backButton;

    public static bool gameIsPaused;

    void Start()
    {
        pauseCanvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

	// Used in the pause menu if you want to make return button.
    public void PressOfButton()
    {
        gameIsPaused = false;
        PauseGame();
    }

	// Pauses the game (duh)
    public void PauseGame()
    {
		// Freezes time, shows pause canvas (pause menu), stops audio and unlocks cursor
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            pauseCanvas.enabled = true;
            AudioListener.pause = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            GameObject.Find("Glock").GetComponent<shooting>().enabled = false;
        }
        else
        {
            Time.timeScale = 1;
            pauseCanvas.enabled = false;
            AudioListener.pause = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            GameObject.Find("Glock").GetComponent<shooting>().enabled = true;
        }
    }
}
