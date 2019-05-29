using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodControl : MonoBehaviour
{
    public Image hps;
    private bool hpstart;
    private float hurt = 0.2f, all = 1;

    // Start is called before the first frame update
    void Start()
    {
        hpstart = true;
        hps.fillAmount = 1f;//血量

    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.Log("血量：" + hps.fillAmount);
        if (Input.GetKeyDown(KeyCode.A)) {
                hps.fillAmount = hps.fillAmount -= 0.1f;
         }

        if(hps.fillAmount <= 0)
        {

        }
        //hps.fillAmount = (hps.fillAmount -= 0.1f * Time.deltaTime) * hps.fillAmount / (hps.fillAmount);
       /* if (hps.fillAmount <= (all - hurt))//当前血量值 小于等于 目标血量值
            {
                Debug.Log("ting");

                hpstart = false;
                all = hps.fillAmount;//总血量值 被赋值 当前血量值
            }

            Debug.Log("血量2：" + hps.fillAmount);*/
        
    }
}
