using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartOfwordLetterController : MonoBehaviour
{
    public  string letterValue="a";

    public bool isGuessed = false;


    private void Start()
    {
        GetComponent<Text>().text = letterValue;
    }
    // Update is called once per frame
    void Update()
    { 
        if(isGuessed)
        {
            GetComponent<Text>().color = Color.green; 
            if(GetComponent<Text>().fontSize < 140)
                GetComponent<Text>().fontSize++;
         
        }
    }
}
