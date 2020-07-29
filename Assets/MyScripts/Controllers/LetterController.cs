using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LetterController : MonoBehaviour
{
    public Text currentLetter;
    public GameObject sprite;
    public AudioSource correctClickSound;
    public AudioSource notCorrectClickSound;
    public AudioSource destoroyLetter;
    // Start is called before the first frame update
    void Start()
    {
       //s sprite.GetComponent<Renderer>().material.color = Random.ColorHSV();
       // currentLetter.color = new Color(255 - sprite.GetComponent<Renderer>().material.color.r, 255 - sprite.GetComponent<Renderer>().material.color.g, 255 - sprite.GetComponent<Renderer>().material.color.b);
    }
     
    public void OnClickLetter()
    {
        //Debug.Log(currentLetter.text + " is Pressed");


        if (SceneManager.GetActiveScene().name.Contains("StudyModeGame"))
        {
         

            if (currentLetter.text == GameStates.letterToStudy)
            {
                Destroy(GetComponentInParent<Rigidbody2D>());
                Destroy(GetComponentInParent<BoxCollider2D>());
                GameStates.studyModeNumOfGuesses++;

                correctClickSound.Play();
                transform.parent.transform.gameObject.GetComponentInChildren<Canvas>().enabled = false;
                transform.parent.transform.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
                Instantiate(correctLetterClick_Particles, transform.position, transform.rotation);

                StartCoroutine(DelayDestroy());
                FindObjectOfType<CharacterController>().mouseIsHappy = true;
            }
            else if (currentLetter.text != GameStates.letterToStudy)
            {
               
                notCorrectClickSound.Play();
                Camera.main.GetComponent<CameraController>().ShakeCamera();
                FindObjectOfType<CharacterController>().mouseIsSad = true;
            }
            else
            {
                FindObjectOfType<CharacterController>().mouseIsIdle = true;
            }
        }
        
    }
    public ParticleSystem correctLetterClick_Particles;
    public ParticleSystem notCorrectLetterClick_Particles;

    IEnumerator DelayDestroy()
    {
        yield return new WaitWhile(() => correctClickSound.isPlaying);
                Destroy(transform.parent.gameObject);
    }
    private void OnDestroy()
    {
        if(currentLetter.text != GameStates.letterToStudy)
        {
            Instantiate(notCorrectLetterClick_Particles, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(correctLetterClick_Particles, transform.position, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
