using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionWordSet : MonoBehaviour
{
    public GameObject partOfWord, content;
    float offset;
    public List<GameObject> lettersToGuess;
    // Start is called before the first frame update
    void Start()
    {
        lettersToGuess = new List<GameObject>();
        offset = partOfWord.GetComponent<RectTransform>().rect.width* 1.1f + 10;
        for (int i =0;i<GameStates.currentMission.Length;i++)
        {
            GameObject newLetter = Instantiate(partOfWord,Vector3.zero, Quaternion.identity, content.transform);
            newLetter.GetComponent<RectTransform>().anchoredPosition = new Vector3((i+1) * offset, 0,0);
            newLetter.GetComponent<PartOfwordLetterController>().letterValue = GameStates.currentMission.ToCharArray()[i].ToString();
            lettersToGuess.Add(newLetter);
        }
    }

    

}
