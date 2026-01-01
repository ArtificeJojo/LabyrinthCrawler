using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMode : MonoBehaviour
{
    public GameObject player;
    public bool isActive;
    private Collider myColl;
    private KillPlayer killPlayer;
   
    // Start is called before the first frame update
    void Start()
    {
        myColl = player.GetComponent<SphereCollider>();
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab) && !isActive)
        {
            myColl.gameObject.SetActive(false);
            killPlayer.enabled = false;
            isActive = true;
        }
        else if(Input.GetKey(KeyCode.Tab) && isActive)
        {
            myColl.gameObject.SetActive(true);
            killPlayer.enabled=true;
            isActive = false;
        }
    }
}
