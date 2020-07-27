using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMood : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = GameStates.mood + "/"  + GameStates.maximumMood; 
    }
}
