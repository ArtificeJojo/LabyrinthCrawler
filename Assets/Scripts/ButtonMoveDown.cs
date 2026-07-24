using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMoveDown : MonoBehaviour
{
    public GameObject moveObject;
    public int count;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            moveObject.transform.Translate(0, -5, 0);
            count++;
        }
    }
    
    void Update()
    {
        if(count == 1) 
            moveObject.GetComponent<Collider>().isTrigger = false;
    }
}
