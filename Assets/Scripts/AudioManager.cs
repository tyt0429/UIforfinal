using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;    // 进行控制的Mixer变量
    public GameObject isOngameObject;
    public GameObject isOffgameObject;
    private Toggle toggle;

    void Start()
    {
        
        //toggle = this.GetComponent<Toggle>();
    }
    public void SetMasterVolume(float volume)    // 控制主音量的函数
    {

        audioMixer.SetFloat("MasterVolume", volume);
        // MasterVolume为我们暴露出来的Master的参数
    }

    public void SetMusicVolume(float volume)    // 控制背景音乐音量的函数
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void SetSoundEffectVolume(float volume)    // 控制音效音量的函数
    {
        audioMixer.SetFloat("SoundEffectVolume", volume);
    }

    /*public void OnIsOnMasterChanged()
    {

        isOngameObject.SetActive(toggle.isOn);
        isOffgameObject.SetActive(!toggle.isOn);
        if (toggle.isOn)
        {
            audioMixer.SetFloat("MasterVolume", 0);
        }
        else
        {
            audioMixer.SetFloat("MasterVolume", -40);
        }

    }*/


}
