using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMoveSide : MonoBehaviour
{
    public float x, z;
    public GameObject moveObject;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            moveObject.transform.Translate(x, 0, z);
        }
    }
    
}
