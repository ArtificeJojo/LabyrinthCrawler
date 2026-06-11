using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public GameObject respawnButton, quitButton;
    private KillPlayer killPlayer;
    public int moveVal = 2000;
    
    // Start is called before the first frame update
    public void Start()
    {
        respawnButton.transform.Translate(moveVal, 0, 0);
        quitButton.transform.Translate(moveVal, 0, 0);
    }

    public void PlayerDeath()
    {
        Time.timeScale = 0;
        respawnButton.transform.Translate(-moveVal, 0, 0);
        quitButton.transform.Translate(-moveVal, 0, 0);
    }
}
