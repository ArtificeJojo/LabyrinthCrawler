using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public int sceneNo = 0;
    public void Restart()
    {
        SceneManager.LoadScene(sceneNo);
    }
}
