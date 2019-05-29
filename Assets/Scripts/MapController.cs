using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    public Image img;
    public float posx, posy; //theif location
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        img.GetComponent<RectTransform>().position = new Vector3(posx, posy, 0);   
    }
}
