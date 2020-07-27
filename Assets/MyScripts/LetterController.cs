using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterController : MonoBehaviour
{
    public Text currentLetter; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClickLetter()
    {
        Debug.Log(currentLetter.text + " is Pressed");
        if(currentLetter.text == GameStates.letterToGuess)
        { 
            GameObject.FindObjectOfType<GameController>().ClearScreen();
            GameStates.SetLetterToGuess();
            GameStates.score++;
        }
        else
        {
            Camera.main.GetComponent<CameraController>().ShakeCamera();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
