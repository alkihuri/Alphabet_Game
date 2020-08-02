using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionSelectButtonController : MonoBehaviour
{
    public string missionName;
    public Image missionSprite;
    public void StartMission()
    {
        GameStates.currentMission = missionName;
        SceneManager.LoadScene("MissionIntro");
    }
    // Start is called before the first frame update
    void Start()
    {
        if(Progress.passedMissions.Contains(missionName))
        {
            GetComponent<Image>().color = Color.green;
        }
        bool cheker = true;
         
            foreach (char c_line in missionName.ToCharArray())
            {
                string line = c_line.ToString();
                if (!Progress.passedLetters.Contains(line))
                {
                    cheker = false;
                }
            }
       
        GetComponent<Button>().interactable = cheker;
        missionSprite.sprite = Resources.Load<Sprite>("Missions/Sprites/" + missionName)as Sprite;
    }
 
     
}
