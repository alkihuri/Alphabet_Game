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
        GameStates.mood = GameStates.maximumMood;
        GameStates.studyModeNumOfGuesses = 0;
        letters = GetComponentsInChildren<Text>().ToList();
    }
    IEnumerator GoNextLevel()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Letter"))
        {
            Destroy(go);
        }
        yield return new WaitForSeconds(0.5f);
        if (SceneManager.GetActiveScene().name == "StudyModeGame")
        {
            GameStates.level=2;
            SceneManager.LoadScene("StudyModeGame_2");
        }
        if (SceneManager.GetActiveScene().name == "StudyModeGame_2")
        {
            GameStates.level=3;
            SceneManager.LoadScene("StudyModeGame_3");
        }
        if (SceneManager.GetActiveScene().name == "StudyModeGame_3")
        {
            GameStates.level =1 ;
            Progress.passedLetters.Add(GameStates.letterToStudy);
            Debug.Log("Буква" + GameStates.letterToStudy + "Добавлена");
            SceneManager.LoadScene("StudyModeFinish");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(GameStates.studyModeNumOfGuesses >= letters.Count -1)
        {
            StartCoroutine(GoNextLevel());
        }
        if(GameStates.mood < 1)
        {
            SceneManager.LoadScene("SelectLetter");
        }

        for(int i=0;i< letters.Count; i++)
        {
            letters[i].text = GameStates.letterToStudy;
            if(i < GameStates.studyModeNumOfGuesses )
            {

                letters[i].color = Color.green;
            }
            else
            {
                letters[i].color = Color.gray;
                if (SceneManager.GetActiveScene().name == "StudyModeGame_3")
                    letters[i].text = "?";
            }
        }
    }
 
}
