using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLvl : MonoBehaviour
{
    public int nextScene;
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(nextScene);
    }
}
