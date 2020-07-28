using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectButtonController : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void SetLetterToStudyMode()
    {
        GameStates.letterToStudy = GetComponentInChildren<Text>().text; 
        if(Progress.passedLetters.Contains(GameStates.letterToStudy))
        {
             //// Если буква / кнопка пройдена....
        }
        SceneManager.LoadScene("StudyModeGame");
    }
}
