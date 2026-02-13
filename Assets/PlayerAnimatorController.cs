using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator anim ;
    private CharacterMovement movement;
    Rigidbody rb ;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        movement = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("playerSpeed", rb.velocity.magnitude);
        anim.SetBool("IsGrounded", movement.IsGrounded);

        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("doRoll");
        }
        
    }
}
