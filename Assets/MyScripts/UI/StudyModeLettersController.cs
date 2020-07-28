using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StudyModeLettersController : MonoBehaviour
{
    List<Text> letters;
    // Start is called before the first frame update
    void Start()
    {
        letters = GetComponentsInChildren<Text>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameStates.studyModeNumOfGuesses == letters.Count)
        {
            SceneManager.LoadScene("SelectLetter");
            Progress.passedLetters.Add(GameStates.letterToStudy);
            Progress.SaveData();
        }

        for(int i=0;i< letters.Count; i++)
        {
            letters[i].text = GameStates.letterToStudy;
            if(i < GameStates.studyModeNumOfGuesses)
            {
                letters[i].color = Color.green;
            }
            else
            {
                letters[i].color = Color.gray; 
            }
        }
    }
}
