using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudyModeSceneController : MonoBehaviour
{
    public GameObject letter;
    // Start is called before the first frame update
    void Start()
    {
        GameStates.studyModeNumOfGuesses = 0;
        StartCoroutine(SpawnRandon());
        StartCoroutine(SpawnCorrect());
    }
    IEnumerator SpawnCorrect()
    {
        while (GameStates.studyModeIsOn == true)
        {
            yield return new WaitForSeconds(1.5f);
            GameObject newOne = Instantiate(letter, transform.position + new Vector3(Random.Range(-2.5f, 2), 0, 0), Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.letterToStudy;
            newOne.GetComponentInChildren<LetterController>().sprite.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
    IEnumerator SpawnRandon()
    {
       while(1==1)
        {
            yield return new WaitForSeconds(0.9f);
            GameObject newOne = Instantiate(letter, transform.position + new Vector3(Random.Range(-2.5f, 2), 0, 0), Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.russianAlphabet.Split(',')[Random.Range(0, GameStates.russianAlphabet.Length/2-1)];
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
