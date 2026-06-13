using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathText, deathPanel ;
    private KillPlayer killPlayer;
    public int moveVal = 2000;
    
    // Start is called before the first frame update
    public void Start()
    {
        deathText.transform.Translate(moveVal, 0, 0);
        deathPanel.transform.Translate(moveVal, 0, 0);
    }

    public void PlayerDeath()
    {
        Time.timeScale = 0;
        deathText.transform.Translate(-moveVal, 0, 0);
        deathPanel.transform.Translate(-moveVal, 0, 0);
    }
}
