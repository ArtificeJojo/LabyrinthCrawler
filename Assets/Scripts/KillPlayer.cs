 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private DebugMode debugMode;
    private DeathScreen deathScreen;
    public int sceneNo = 0;

    private void Start()
    {
        debugMode = GetComponent<DebugMode>();
        deathScreen.Start();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (debugMode.isActive)
        {
            return;
        }

        if(other.tag == "Walls")
        {
            Destroy(gameObject);
            deathScreen.PlayerDeath();
        }
    }
}
