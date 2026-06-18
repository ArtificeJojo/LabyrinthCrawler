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
            moveObject.transform.position = new Vector3(x, moveObject.transform.position.y, z);
        }
    }
    
}
