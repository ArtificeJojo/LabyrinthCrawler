using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject resumeButton, restartButton, quitButton;
    public int moveVal = 2000;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    public void Start()
    {
        resumeButton.transform.Translate(moveVal, 0, 0);
        restartButton.transform.Translate(moveVal, 0, 0);
        quitButton.transform.Translate(moveVal, 0, 0);
    }

    public void Unpause()
    {
        resumeButton.transform.Translate(moveVal, 0, 0);
        restartButton.transform.Translate(moveVal, 0, 0);
        quitButton.transform.Translate(moveVal, 0, 0);
    }
    public void Paused()
    {   
        Time.timeScale = 0f;

        resumeButton.transform.Translate(-moveVal, 0, 0);
        restartButton.transform.Translate(-moveVal, 0, 0);
        quitButton.transform.Translate(-moveVal, 0, 0);

        playerMovement.Disable();
    }
  
}
