using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSliderControl : MonoBehaviour
{
    public Slider slider;
    private float vSbarValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        vSbarValue = GetComponent<Slider>().value;

    }

    // Update is called once per frame
    void Update()
    {    

    }
    public void OnChangedValue()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vSbarValue -= 2.5f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vSbarValue += 2.5f;
        }
    }
}
