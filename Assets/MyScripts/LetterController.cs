using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LetterController : MonoBehaviour
{
    public Text currentLetter;
    public GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
       //s sprite.GetComponent<Renderer>().material.color = Random.ColorHSV();
       // currentLetter.color = new Color(255 - sprite.GetComponent<Renderer>().material.color.r, 255 - sprite.GetComponent<Renderer>().material.color.g, 255 - sprite.GetComponent<Renderer>().material.color.b);
    }
    public void OnClickLetter()
    {
        //Debug.Log(currentLetter.text + " is Pressed");
        Debug.Log(SceneManager.GetActiveScene().name);

        #region AzbukaMode
        if(SceneManager.GetActiveScene().name == "Game")
        {
            if (currentLetter.text == GameStates.letterToGuess)
            {
                GameStates.nextTurn();
                GameObject.FindObjectOfType<GameController>().ClearScreen();
                GameStates.SetLetterToGuess();
                GameStates.score++;
            }
            else
            {
                Camera.main.GetComponent<CameraController>().ShakeCamera();
            }
        }
        #endregion
         
        if(SceneManager.GetActiveScene().name.Contains("StudyModeGame"))
        {
            if (currentLetter.text == GameStates.letterToStudy)
            {
                Destroy(GetComponentInParent<Rigidbody2D>());
                Destroy(GetComponentInParent<BoxCollider2D>());
                GameStates.studyModeNumOfGuesses++;
                Destroy(transform.parent.gameObject);
            }
            else
            {
                Camera.main.GetComponent<CameraController>().ShakeCamera();
            }
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
