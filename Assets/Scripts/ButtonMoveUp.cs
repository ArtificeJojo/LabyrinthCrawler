using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMoveUp : MonoBehaviour
{
    public GameObject moveObject;
    public int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            moveObject.transform.Translate(0, 6, 0);
            count++;
        }
    }

    void Update()
    {
        if(count == 1) 
            moveObject.GetComponent<Collider>().isTrigger = false;
    }
}
