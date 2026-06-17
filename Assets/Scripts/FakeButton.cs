using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeButton : MonoBehaviour
{
    public GameObject killPlayer;
    public DeathScreen deathScreen;
    public PlayerMovement playerMovement;
    public int sceneNo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            StartCoroutine(ExecuteAfterDelay(2.0f));
        }
    }
    
    IEnumerator ExecuteAfterDelay(float delay)
    {
        playerMovement.Disable();
        deathScreen.PlayerDeath();
        
        yield return new WaitForSeconds(delay);
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneNo);
    }
}
