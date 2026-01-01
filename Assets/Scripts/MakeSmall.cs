using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSmall : MonoBehaviour
{
    public float val;
    public GameObject player;
    public Camera cam;
    public MeshRenderer meshR;
    public SphereCollider sCollider;
    //private
    // Start is called before the first frame update

    private void Start()
    {
        meshR = player.GetComponent<MeshRenderer>();
        sCollider = player.GetComponent<SphereCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            meshR.transform.localScale = new Vector3(val, val, val);
            sCollider.transform.localScale = new Vector3(val, val, val);
            cam.transform.localScale = new Vector3(.2f, .2f, .2f);
            
        }
    }
}
