using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_handle : MonoBehaviour
{
   
    public AudioClip handleAudioClip;

    public AudioClip wonPrizeAudioClip;

    private AudioSource audioSource_wonAudio;
    private AudioSource audioSource_handleAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource_handleAudio = GetComponent<AudioSource>();
        audioSource_wonAudio = GetComponent<AudioSource>();
        
    }

    public void playWonPrize()
    {
        audioSource_wonAudio.clip =wonPrizeAudioClip;
        audioSource_wonAudio.Play();
        
    }


    public void playHandleSound()
    {
        audioSource_handleAudio.clip = handleAudioClip;
        audioSource_handleAudio.Play();
    }

   
    

}
