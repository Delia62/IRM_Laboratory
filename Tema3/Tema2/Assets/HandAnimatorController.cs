using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimatorController : MonoBehaviour
{
    [SerializeField] private InputActionProperty triggerAction;
    [SerializeField] private InputActionProperty gripAction;

    private Animator animator;

    private void Start(){
        animator = GetComponent<Animator>();
    }

    private void Update(){
        float triggerActionValue = triggerAction.action.ReadValue<float>();
        float gripActionValue = gripAction.action.ReadValue<float>();

        animator.SetFloat("Trigger", triggerActionValue);
        animator.SetFloat("Grip", gripActionValue);
    }
}
