using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text lettertoGuestUI;
    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lettertoGuestUI.text = GameStates.letterToGuess;
        scoreUI.text = "Score : " + GameStates.score;
    }
}
