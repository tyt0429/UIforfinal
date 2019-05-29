using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public Text TimeUI;
    int time_int = 480;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void timer()
    {
        time_int -= 1;
        TimeUI.text = "Time " + time_int + " s";
        if(time_int == -1)
        {
            TimeUI.text = "Time up";
            CancelInvoke("timer");
        }
    }
}
