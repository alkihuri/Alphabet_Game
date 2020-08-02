using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour
{
    public Image BtnSprite;
     public void LangChangeClick()
    {
        if(GameStates.currentAlphabet == "RUS")
        {
            GameStates.currentAlphabet  = "AVR";
        }
        else
        {
            GameStates.currentAlphabet = "RUS";
        }

        switch (GameStates.currentAlphabet)
        {
            case "RUS": 
                GameStates.SetRussianAlphabetAndMissions(); 
                break;
            case 
                "AVR": GameStates.SetAvarianAlphabetAndMissions(); 
                break;
            default: GameStates.SetRussianAlphabetAndMissions(); break;

        }
        BtnSprite.sprite = Resources.Load<Sprite>("Flags/" + GameStates.currentAlphabet) as Sprite;
    }
}
