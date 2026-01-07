using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject resumeButton, restartButton, quitButton;
    public int sceneNo;
    // Start is called before the first frame update
    void Start()
    {
      resumeButton.SetActive(false);
      restartButton.SetActive(false);
      quitButton.SetActive(false);
    }

    public void Unpause()
    {
        resumeButton.SetActive(false);
        restartButton.SetActive(false);
        quitButton.SetActive(false);
    }
    public void Paused()
    {   
        Time.timeScale = 0f;

        resumeButton.SetActive(true);
        restartButton.SetActive(true);
        quitButton.SetActive(true);
    }
  
}
