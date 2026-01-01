using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollectDiamonds : MonoBehaviour
{
    public GameObject diamond; 
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Works");
        Destroy(diamond);
        //Update UI
    }
}
