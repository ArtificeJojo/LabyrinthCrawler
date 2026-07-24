using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    public float turn;
    public GameObject turnObject;
    public int count;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            turnObject.transform.Rotate(0, turn, 0);
            count++;
        }
    }
    
    void Update()
    {
        if(count == 1) 
            turnObject.GetComponent<Collider>().isTrigger = false;
    }
}
