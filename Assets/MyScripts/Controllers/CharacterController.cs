using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public Animator animator;
    public bool mouseIsHappy; 
    public bool mouseIsSad;
    public bool mouseIsIdle;

    public AudioSource happySound, sadSoud;

    // Start is called before the first frame update
    void Start()
    {
      
        animator = GetComponent<Animator>();
    }
    private void LateUpdate()
    {
        mouseIsIdle = true;
        mouseIsSad = false;
        mouseIsHappy = false;
    }
    private void Update()
    { 
        

        if (mouseIsSad)
        {
            animator.SetTrigger("Sad");
        }
        if (mouseIsHappy)
        {
            animator.SetTrigger("Happy");
        }
        if(mouseIsIdle)
        {
            animator.SetTrigger("Idle");
        }
 
    }
   
}
