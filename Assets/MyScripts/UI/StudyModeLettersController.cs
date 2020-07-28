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
        letters = GetComponentsInChildren<Text>().ToList();
    }
    IEnumerator GoToSelectScene()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Letter"))
        {
            Destroy(go);
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("SelectLetter");
        Progress.passedLetters.Add(GameStates.letterToStudy);
    }
    // Update is called once per frame
    void Update()
    {
        if(GameStates.studyModeNumOfGuesses >= letters.Count -1)
        {
            StartCoroutine(GoToSelectScene());
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
            }
        }
    }
 
}
