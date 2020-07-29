using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    private void Start()
    {
        string scene = SceneManager.GetActiveScene().name;


        switch(scene)
        {
            case "Start": GameStates.level = 0;  break;
            case "StudyModeGame": GameStates.level = 1; break;
            case "StudyModeGame_2": GameStates.level = 2; break;
            case "StudyModeGame_3": GameStates.level = 3; break; 
            case "StudyModeFinish": GameStates.level = 4; break;
            default: GameStates.level = 0; break;
        }
         
    }
    private void OnDestroy()
    {
        foreach(ParticleSystem ps in GameObject.FindObjectsOfType<ParticleSystem>())
        {
            Destroy(ps);
        }
    }
    public void ChangeScene(string name)
    {
        if(name == "Start" || name == "Game")
        {
            GameStates.mood = GameStates.maximumMood;
            GameStates.turn = 0;
        }
        SceneManager.LoadScene(name);
    }
    public void ApplicationExit()
    {
        Application.Quit();
    }
}
