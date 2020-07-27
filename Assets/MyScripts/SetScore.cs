using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "Score : " + GameStates.score;
    }
}
