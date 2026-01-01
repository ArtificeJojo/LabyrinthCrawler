using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiagButton : MonoBehaviour
{
   public void DiagButtonControls(string DiagonalControls)
    {
        SceneManager.LoadScene(DiagonalControls);

    }
}
