using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMissionWord : MonoBehaviour
{
     
    void Start()
    {
        GetComponent<Text>().text = GameStates.currentMission.ToString();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while(1==1)
        {
            yield return new WaitForSeconds(0.5f);
            GetComponent<Text>().color = Random.ColorHSV();
        }
    }
   
}
