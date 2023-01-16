using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorParam : MonoBehaviour
{
    private Animator animator;

    float horizontalMove;
    float verticalMove;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        animator.SetBool("New Bool", false);

        if(horizontalMove ==0 && verticalMove ==0){
            animator.SetBool("New Bool", false);
        }
        else{
            animator.SetBool("New Bool", true);
        }

    }

}
