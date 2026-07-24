using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMoveSide : MonoBehaviour
{
    public float x, z;
    static GameObject moveObject;
    public int count;
    public Collider coll;

    void Start()
    {
        coll =  moveObject.GetComponent<Collider>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            moveObject.transform.Translate(x, 0, z);
            count++;
        }

        if (count == 1)
            coll.enabled = false;
    }
}
