using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator anim;
    public PlayerMovement playerMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        while (playerMovement.isMoving == true)
        {
            anim.SetTrigger("move");
        }
        
        //play death anim when player dies
        

    }
}
