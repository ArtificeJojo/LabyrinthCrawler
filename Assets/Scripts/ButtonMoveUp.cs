using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMoveUp : MonoBehaviour
{
    public GameObject moveObject;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            moveObject.transform.Translate(0, 6, 0);
        }
    }
}
