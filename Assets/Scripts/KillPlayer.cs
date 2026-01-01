 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private DebugMode debugMode;
    public int sceneNo = 0;

    private void Start()
    {
        debugMode = GetComponent<DebugMode>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (debugMode.isActive)
        {
            return;
        }

        if(other.tag == "Walls")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(sceneNo);
        }
    }
}
