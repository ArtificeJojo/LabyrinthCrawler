using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    public float turn;
    public GameObject turnObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            turnObject.transform.Rotate(0, turn, 0);
        }
    }
}
