using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarControl : MonoBehaviour
{
    public Scrollbar scrollbar;
    private float vSbarValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        vSbarValue = GetComponent<Scrollbar>().value;

    }

    // Update is called once per frame
    void Update()
    {    
        
    }
    public void OnChangedValue()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vSbarValue += 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vSbarValue -= 0.1f;
        }
    }
}
