using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeButton : MonoBehaviour
{
    public GameObject killPlayer;
    public int sceneNo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(killPlayer);
            SceneManager.LoadScene(sceneNo);
        }
    }
}
