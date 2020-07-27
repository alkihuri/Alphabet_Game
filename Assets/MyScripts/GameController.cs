using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ClearScreen()
    {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("Letter"))
        {
            Destroy(go);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.gameObject.GetComponentInChildren<LetterController>().currentLetter.text == GameStates.letterToGuess)
        {
            Debug.Log("Looser");
            if (GameStates.mood > 0)
            {
                GameStates.mood--;
            }
            if(GameStates.mood == 0)
            {
                SceneManager.LoadScene("Finish");
            }
        }
        Destroy(collision.transform.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
