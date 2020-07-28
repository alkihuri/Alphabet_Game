using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StudyModeSceneController : MonoBehaviour
{
    public GameObject letter;
    public float randomRange;
    public Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        

            randomRange = Camera.main.orthographicSize / 5;
        GameStates.studyModeNumOfGuesses = 0;
        GameStates.mood = GameStates.maximumMood;
        StartCoroutine(SpawnRandon());
        StartCoroutine(SpawnCorrect());
    }
    IEnumerator SpawnCorrect()
    {
        while (GameStates.studyModeIsOn == true)
        {
            yield return new WaitForSeconds(1.5f);
            ///transform.position + new Vector3(Random.Range(-randomRange, randomRange)
            GameObject newOne = Instantiate(letter, positions[Random.Range(0,positions.Length)].position, Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.letterToStudy;
            if (SceneManager.GetActiveScene().name == "StudyModeGame")
                newOne.GetComponentInChildren<LetterController>().sprite.GetComponent<SpriteRenderer>().color = Color.green;
            newOne.GetComponent<Rigidbody2D>().gravityScale = GameStates.gravityOfLetters;
        }
    }
    IEnumerator SpawnRandon()
    {
       while(GameStates.studyModeIsOn == true)
        {
            yield return new WaitForSeconds(0.9f);
            ///transform.position + new Vector3(Random.Range(-2.5f, 2)
            GameObject newOne = Instantiate(letter, positions[Random.Range(0, positions.Length)].position, Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.russianAlphabet.Split(',')[Random.Range(0, GameStates.russianAlphabet.Length/2-1)];
            newOne.GetComponent<Rigidbody2D>().gravityScale = GameStates.gravityOfLetters;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInChildren<LetterController>().currentLetter.text.Equals(GameStates.letterToStudy))
        { 
            GameStates.mood--;
        }
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
