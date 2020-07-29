using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSetOn : MonoBehaviour
{
    public  Toggle hardModeTogle;
    public Scrollbar gravity;
    private void Start()
    {
        hardModeTogle.isOn = GameStates.hardMode;
        gravity.value = GameStates.gravityOfLetters/ 0.15f;
    }
    public void SetHardModeValue()
    {
        GameStates.hardMode = hardModeTogle.isOn; 
    }
    public void SetLettersSpeed()
    {
        GameStates.gravityOfLetters = gravity.value * 0.15f;
    }
}
