using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterController : MonoBehaviour
{
    public Text currentLetter;
    public GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite.GetComponent<Renderer>().material.color = Random.ColorHSV();
        currentLetter.color = new Color(255 - sprite.GetComponent<Renderer>().material.color.r, 255 - sprite.GetComponent<Renderer>().material.color.g, 255 - sprite.GetComponent<Renderer>().material.color.b);
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
    public ParticleSystem ps;
    private void OnDestroy()
    {
        Instantiate(ps, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
