using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceBGM;
    [SerializeField] Slider sliderBGM;

    [SerializeField] AudioSource audioSourceSE;
    [SerializeField] Slider sliderSE;

    [SerializeField] AudioClip[] audioClipBGM;
    [SerializeField] AudioClip[] audioClipSE;

    public static SoundManager Instance;

    private void Awake()
    {
        if(Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        sliderBGM.value = audioSourceBGM.volume;
        sliderSE.value = audioSourceSE.volume;
    }
    public void SetBGMVolume(float volume) 
    {
        audioSourceBGM.volume = volume;
    }
    public void SetSEVolume(float volume)
    {
        audioSourceSE.volume = volume;
    }
    public void PlayBGM(int num) 
    {
        audioSourceBGM.clip = audioClipBGM[num];
        audioSourceBGM.Play();
    }
    public void PlaySE(int num) 
    {
        audioSourceSE.PlayOneShot(audioClipSE[num]);
    }
}
