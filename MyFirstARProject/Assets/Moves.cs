using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (animator != null)
        {
            
            if (Input.GetKeyDown(KeyCode.A))
            {
               
                animator.SetBool("isAttacking", true);  
            }

           
            if (Input.GetKeyUp(KeyCode.A))
            {
               
                animator.SetBool("isAttacking", false);  
            }
        }
    }
}
