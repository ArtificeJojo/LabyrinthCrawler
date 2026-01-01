using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public int num;
    public void ReturnButton()
    {
        SceneManager.LoadScene(num);
    }
}
