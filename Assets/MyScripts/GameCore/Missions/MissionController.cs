using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionController : MonoBehaviour
{
    public GameObject letterToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GameStates.numOfMissionModeGuesedLetter = 0;
        GameStates.missionModeGuesedLetter.Clear();
        GameStates.missionWrongTaps = 0;
        StartCoroutine(SpawnCorrect());
        StartCoroutine(SpawnRandom());
    }
    private void Update()
    {
        GameStates.numOfMissionModeGuesedLetter = GameObject.FindObjectsOfType<PartOfwordLetterController>().ToList().Where(o => o.isGuessed == false).ToList().Count;
        Debug.Log(GameStates.numOfMissionModeGuesedLetter);
        if (GameStates.numOfMissionModeGuesedLetter == 0)
        {
            Debug.Log("Huraaaaah");

            StartCoroutine(DelaySceneChange("MissionFinish"));
        }
        if(GameStates.missionWrongTaps>2)
        {
            StartCoroutine(DelaySceneChange("BadFinish")); 
        }
    }

    
    IEnumerator DelaySceneChange(string name)
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Letter"))
        {
            Destroy(go);
        }
        foreach (ParticleSystem ps in GameObject.FindObjectsOfType<ParticleSystem>())
        {
            Destroy(ps);
        }
        yield return new WaitForSeconds(0.4f);
        Progress.passedMissions.Add(GameStates.currentMission);
        SceneManager.LoadScene(name);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    IEnumerator SpawnRandom()
    {
        while (GameStates.isMissionModeOn)
        {
            yield return new WaitForSeconds(2.5f);
            GameObject newCorrectOne = Instantiate(letterToSpawn, transform.position - new Vector3(2,0,0)*Random.Range(-1,1), transform.rotation);

            string newAlphaBet = GameStates.russianAlphabet;

            foreach(string value in GameStates.currentMission.Split(','))
            {
                newAlphaBet = newAlphaBet.Replace(value + ",", "");
            }

            newCorrectOne.GetComponentInChildren<Text>().text = newAlphaBet.Split(',')[(Random.Range(0, newAlphaBet.Length / 2 - 1))];
        }
    }

    IEnumerator SpawnCorrect()
    {
       while (GameStates.isMissionModeOn)
        {
            yield return new WaitForSeconds(2.7f);
            GameObject newCorrectOne = Instantiate(letterToSpawn, transform.position - new Vector3(2, 0, 0) * Random.Range(-1, 1), transform.rotation);
            newCorrectOne.GetComponentInChildren<Text>().text = GameStates.currentMission.ToCharArray()[Random.Range(0, GameStates.currentMission.Length)].ToString();
             
        }
    }
}
