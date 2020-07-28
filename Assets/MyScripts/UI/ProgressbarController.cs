using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressbarController : MonoBehaviour
{
    ProgressBar pb;
    // Start is called before the first frame update
    void Start()
    {
        pb = GetComponent<ProgressBar>();
    }

    // Update is called once per frame
    void Update()
    {
        pb.BarValue = GameStates.turn * (100 / 33);
    }
}
