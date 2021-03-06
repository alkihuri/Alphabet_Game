﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLetterManager : MonoBehaviour
{
    public GameObject scrollViewContent;
    public GameObject buttonToSet;
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = buttonToSet.GetComponent<RectTransform>().rect.height * 1.5f;
        for(int i =0; i< GameStates.main_alphabet.Split(',').Length;i++ )
        {
            PutLetterOnScreen(i);
        }
    }

    private void PutLetterOnScreen(int i)
    {


        for (int j = -1; j < 2; j++)
        {

            GameObject newOne = new GameObject();
            string value = GameStates.main_alphabet.Split(',')[i + j + 1 + (i * 2)].ToString();
            if (value != "")
                newOne = Instantiate(buttonToSet, new Vector3(j * Camera.main.pixelWidth / 3, -(offset * (i + 1)), 0), Quaternion.identity, scrollViewContent.transform);


            newOne.GetComponentInChildren<Text>().text = value;

            if (Progress.passedLetters.Contains(newOne.GetComponentInChildren<Text>().text.ToString()))
            {

                newOne = Instantiate(buttonToSet, new Vector3(j * Camera.main.pixelWidth / 3, -(offset * (i + 1)), 0), Quaternion.identity, scrollViewContent.transform);
                newOne.GetComponentInChildren<Text>().text = GameStates.main_alphabet.Split(',')[i + j + 1 + (i * 2)].ToString();
                if (Progress.passedLetters.Contains(newOne.GetComponentInChildren<Text>().text.ToString()))
                {

                    newOne.GetComponent<Image>().color = Color.green;
                }


            }

        }

    }

}
