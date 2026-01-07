using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour
{
    public int sceneNo = 0;
    public void Resume()
    {
        SceneManager.LoadScene(sceneNo);
    }
}
