using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControlle : MonoBehaviour
{
    private Animator animator;

    public GameObject PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("ParamB1", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("ParamB1", false);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("ParamB2", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("ParamB2", false);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("ParamB3", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("ParamB3", false);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("ParamB4", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("ParamB4", false);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("ParamB5", true);
            PlayerController.GetComponent<PlayercontrollerMouseRotateControlle>().enabled = false;
            
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("ParamB5", false);
            PlayerController.GetComponent<PlayercontrollerMouseRotateControlle>().enabled = true;
        }
    }
}
