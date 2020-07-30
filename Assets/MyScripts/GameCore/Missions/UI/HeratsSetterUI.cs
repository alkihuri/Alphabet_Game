using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeratsSetterUI : MonoBehaviour
{
    public List<GameObject> sprites;


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < sprites.Count; i++)
        {
            if ((i + 1) <= 3 -GameStates.missionWrongTaps)
            {
                sprites[i].SetActive(true);
            }
            else
            {
                sprites[i].SetActive(false);
            }
        }
    }
}
