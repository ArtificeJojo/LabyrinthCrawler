using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton1 : MonoBehaviour
{   public void Quit()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
