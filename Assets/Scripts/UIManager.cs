using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject SettingCanvas;
    public GameObject TheifCanvas;
    public GameObject SecurityCanvas;
    public GameObject MapCanvas;
    public GameObject MonitorCanvas;
    public GameObject LosingCanvas;
    public GameObject WinCanvas;
    public int player;
    public Text TimeUITheif; //Theif TimeUI
    public Text TimeUISecurity; //Security TimeUI
    int time_int = 2;

    bool isplay = true;
    bool ispause = false;
    bool MapOn = false;
    bool MoniorOn = false;
    bool SettingOn = false;


    // Start is called before the first frame update
    void Start()
    {
        startGame();
        InvokeRepeating("timer", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (isplay)
        {
            if(player == 1) //theif
            {

            }else if(player == 2 || player == 3 || player == 4) //security
            {
                if (Input.GetKeyDown(KeyCode.Z) && !MapOn)
                {
                    MapCanvas.SetActive(true);
                    MapOn = true;
                }else if (Input.GetKeyDown(KeyCode.Z) && MapOn)
                {
                    MapCanvas.SetActive(false);
                    MapOn = false;
                }

                if (Input.GetKeyDown(KeyCode.X) && !MoniorOn)
                {
                    MonitorCanvas.SetActive(true);
                    MoniorOn = true;
                }
                else if (Input.GetKeyDown(KeyCode.X) && MoniorOn)
                {
                    MonitorCanvas.SetActive(false);
                    MoniorOn = false;
                }

            }
            if (Input.GetKeyDown(KeyCode.S) && !SettingOn)
            {
                SettingCanvas.SetActive(true);
                SettingOn = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (Input.GetKeyDown(KeyCode.S) && SettingOn)
            {
                SettingCanvas.SetActive(false);
                SettingOn = false;
            }



        }
        else {
            
        }

        

    }

    private void startGame()
    {
        if(player == 1)
        {
            TheifCanvas.SetActive(true);
        }else if(player == 2 || player == 3 || player == 4)
        {
            SecurityCanvas.SetActive(true);
        }
        isplay = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void CloseSettingBtn()
    {
        SettingCanvas.SetActive(false);
        if (player == 1)
        {
            TheifCanvas.SetActive(true);
        }
        else if (player == 2 || player == 3 || player == 4)
        {
            SecurityCanvas.SetActive(true);
        }
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void timer()
    {
        time_int -= 1;
        TimeUITheif.text = "Time " + time_int + " s";
        TimeUISecurity.text = "Time " + time_int + " s";
        if (time_int == -1)
        {

            TimeUITheif.text = "Time up";
            TimeUISecurity.text = "Time up";
            if (player == 1)
            {
                LosingCanvas.SetActive(true);
                TheifCanvas.SetActive(false);
            }
            CancelInvoke("timer");
        }

        
    }


}
