using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Game")
        {
            animator.SetFloat("Mood", GameStates.mood / GameStates.maximumMood);
        }
        if(SceneManager.GetActiveScene().name == "StudyModeGame")
        {
            animator.SetFloat("Mood", GameStates.studyModeNumOfGuesses / GameStates.studyModeMaximumNumOfGuesses);
        }
    }
}
