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
         
        SceneManager.LoadScene("StudyModeGame");
    }
}
