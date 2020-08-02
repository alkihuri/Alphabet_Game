using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            yield return new WaitForSeconds(3f);
            ///transform.position + new Vector3(Random.Range(-randomRange, randomRange)
            GameObject newOne = Instantiate(letter, positions[Random.Range(0,positions.Length)].position, Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.letterToStudy;
            if (SceneManager.GetActiveScene().name == "StudyModeGame")
            {

                newOne.GetComponentInChildren<LetterController>().sprite.GetComponent<SpriteRenderer>().color = Color.green;
            }
            newOne.GetComponent<Rigidbody2D>().gravityScale = GameStates.gravityOfLetters + transform.position.y /8 * transform.position.y / 8;
        }
    }
    IEnumerator SpawnRandon()
    {
       while(GameStates.studyModeIsOn == true)
        {
            yield return new WaitForSeconds(3.1f);
            ///transform.position + new Vector3(Random.Range(-2.5f, 2)
            GameObject newOne = Instantiate(letter, positions[Random.Range(0, positions.Length)].position, Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.main_alphabet.Replace(GameStates.letterToStudy,"").Split(',')[Random.Range(0, GameStates.main_alphabet.Length/2-1)];
            newOne.GetComponent<Rigidbody2D>().gravityScale = GameStates.gravityOfLetters + transform.position.y / 8 * transform.position.y / 8;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInChildren<LetterController>().currentLetter.text.Equals(GameStates.letterToStudy))
        { 
            GameObject.FindObjectOfType<CharacterController>().mouseIsSad = true;
            GameStates.mood--;
        }
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
