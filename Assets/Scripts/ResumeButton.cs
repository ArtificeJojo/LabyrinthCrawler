using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour
{
    public int sceneNo = 0;
    public PauseButton pauseButton;
    public PlayerMovement playerMovement;

    public void Resume()
    {
        Time.timeScale = 1f; 
        pauseButton.Unpause();
        playerMovement.Enable();
    }
}
