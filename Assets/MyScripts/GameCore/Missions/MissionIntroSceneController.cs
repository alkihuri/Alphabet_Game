using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MissionIntroSceneController : MonoBehaviour
{
    VideoPlayer vp;
    public GameObject[] forRemovingFromScreen;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        vp = GameObject.FindObjectOfType<VideoPlayer>();
        vp.clip = Resources.Load<VideoClip>("Missions/" + GameStates.currentMission) as VideoClip; 
        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(vp)
            if(System.Convert.ToSingle(vp.frame) == vp.frameCount-1)
            {
                foreach(GameObject gom in forRemovingFromScreen)
                {
                    Destroy(gom);
                }
                panel.SetActive(true);
            }
    }
}
