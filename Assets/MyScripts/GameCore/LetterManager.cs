using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterManager : MonoBehaviour
{
    public GameObject letterExample;
    public bool spawnIsOn;
    // Start is called before the first frame update
    void Start()
    {
        spawnIsOn = true;
        GameStates.SetLetterToGuess();
        StartCoroutine(SpawnLetter());
    }

     IEnumerator SpawnLetter()
    {
        while (spawnIsOn)
        {
            yield return new WaitForSeconds(0.9f);
            GameObject newOne = Instantiate(letterExample, transform.position + new Vector3(Random.Range(-2.5f, 2), 0, 0), Quaternion.identity);
            newOne.GetComponentInChildren<Text>().text = GameStates.russianAlphabet.Split(',')[Random.Range(0 + GameStates.turn, GameStates.turn + 3)];
        }
    }
}
