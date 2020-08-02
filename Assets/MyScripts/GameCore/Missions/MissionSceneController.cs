using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionSceneController : MonoBehaviour
{
    public GameObject content;
    public GameObject missionSelectBtn;
    private float offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = missionSelectBtn.GetComponentInChildren<RectTransform>().rect.height * 1.2f;
        for (int i = 0; i < GameStates.missons.Split(',').Length; i++)
        {
            SetMissionOnScrollView(GameStates.missons.Split(',')[i], i);
        }
    }

     

    private void SetMissionOnScrollView(string value, int i)
    {
        GameObject newOneBtn = Instantiate(missionSelectBtn, new Vector3(0, -(i) * offset, 0), Quaternion.identity, content.transform);
        newOneBtn.GetComponentInChildren<Text>().text = value;
        newOneBtn.GetComponent<MissionSelectButtonController>().missionName = value;
    }
}
