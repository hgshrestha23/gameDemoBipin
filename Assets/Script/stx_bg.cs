using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stx_bg : MonoBehaviour
{

    public AudioClip bgAudioClip;

    private AudioSource audioSource_bgAudio;
    private bool isMuted = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource_bgAudio = GetComponent<AudioSource>();

        audioSource_bgAudio.clip = bgAudioClip;
        audioSource_bgAudio.volume = 0.2f;
        audioSource_bgAudio.Play();
    }

    public void muteAudio()
    {
        if(isMuted == false){
            print(audioSource_bgAudio.volume);
            audioSource_bgAudio.volume = 0f;
            isMuted = true;
        }else{
            print(audioSource_bgAudio.volume);
            audioSource_bgAudio.volume = 0.2f;
            isMuted = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
