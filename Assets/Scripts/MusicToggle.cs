using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public GameObject isOngameObject;
    public GameObject isOffgameObject;
    public Slider BGMSlider;
    private Toggle toggle;
    public AudioSource audioSource;
    private float volume;

    // Start is called before the first frame update
    void Start()
    {
        toggle = this.GetComponent<Toggle>();
        BGMSlider = this.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void OnIsOnChanged()
    {

        isOngameObject.SetActive(toggle.isOn);
        isOffgameObject.SetActive(!toggle.isOn);
        if (toggle.isOn)
        {
            audioSource.volume = 0.5f;
        }
        else
        {
            audioSource.volume = 0;
        }

    }

    public void OnValueChanged ()
    {
        audioSource.volume = BGMSlider.value;
        if (!toggle.isOn)
        {
            isOngameObject.SetActive(true);
            isOffgameObject.SetActive(false);
        }
    }
}
