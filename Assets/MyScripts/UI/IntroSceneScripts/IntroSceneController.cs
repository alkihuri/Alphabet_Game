using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntroSceneController : MonoBehaviour
{
    VideoPlayer vp;
    public GameObject uiPanel;

    public GameObject [] otherUI;
    // Start is called before the first frame update
    void Start()
    {
        vp = GameObject.FindObjectOfType<VideoPlayer>();
        vp.clip = Resources.Load<VideoClip>("Videos/"+GameStates.letterToStudy) as VideoClip;
        Debug.Log("Videos/" + GameStates.letterToStudy);
        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
       // GameObject.FindObjectOfType<ProgressBar>().BarValue = System.Convert.ToSingle(vp.frame + 1)  / vp.frameCount * 100;         
        if (System.Convert.ToSingle(vp.frame)  == vp.frameCount - 1)
        {

            GameObject.FindObjectOfType<Animator>().SetBool("isPlay", true);

            foreach(GameObject gmo in otherUI)
            {
                gmo.SetActive(false);
            }
            uiPanel.SetActive(true);
            
        }
         
    }
}
