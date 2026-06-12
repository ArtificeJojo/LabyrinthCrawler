 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private DebugMode debugMode;
    public DeathScreen deathScreen;
    public PlayerMovement playerMovement;
    public int sceneNo = 0;

    private void Start()
    {
        debugMode = GetComponent<DebugMode>();
        deathScreen.Start();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (debugMode.isActive)
        {
            return;
        }

        if(other.tag == "Walls")
        {
            playerMovement.Disable();
            deathScreen.PlayerDeath();
        }
    }
}
