using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class NewFight : MonoBehaviour
{
    public Animator otherCharacter;   
    private Animator animator;
    public float attackDistance = 0.25f; 

    private bool isAttacking = false;
        
    void Start()
    {
        VuforiaConfiguration.Instance.Vuforia.MaxSimultaneousImageTargets = 4;
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (animator != null && otherCharacter != null)
        {
            float distanceToOtherCharacter = Vector3.Distance(transform.position, otherCharacter.transform.position);

         
            if (distanceToOtherCharacter <= attackDistance && !isAttacking)
            {
                animator.SetBool("isAttacking", true);  
                isAttacking = true;                     
            }
          
            else if (distanceToOtherCharacter > attackDistance && isAttacking)
            {
                animator.SetBool("isAttacking", false); 
                isAttacking = false;                    
            }
        }
    }
}
