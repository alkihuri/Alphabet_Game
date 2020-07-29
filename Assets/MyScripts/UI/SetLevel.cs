using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetLevel : MonoBehaviour
{

    public List<Image> spriteList;

    // Start is called before the first frame update
    void Start()
    {
        if(GameStates.level>1)
        {
            GetComponent<AudioSource>().Play();
        }
        spriteList = GetComponentsInChildren<Image>().ToList();
       for(int i=0;i<3;i++)
        {
            if((i+1)<GameStates.level || SceneManager.GetActiveScene().name.Contains("Finish") )
            {
                spriteList[i].enabled = true;
            }
            else
            {
                spriteList[i].enabled = false; 
            }
        }
    }
     
}
