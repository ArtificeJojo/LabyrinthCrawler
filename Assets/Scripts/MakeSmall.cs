using JetBrains.Annotations;
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
    public float posx, posz;
    // Start is called before the first frame update

    private void Start()
    {
        meshR = player.GetComponent<MeshRenderer>();
        sCollider = player.GetComponent<SphereCollider>();
        posx = player.transform.position.x;
        posz = player.transform.position.z;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            meshR.transform.localScale = new Vector3(val, val, val);
            sCollider.transform.localScale = new Vector3(val, val, val);
            cam.transform.position = new Vector3(posx, 7, posz);
            //Fix this
            
        }
    }
}
