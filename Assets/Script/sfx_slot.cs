using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_slot : MonoBehaviour
{
    public AudioClip slotAudioClip;
   
    private AudioSource audioSource_slotAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource_slotAudio = GetComponent<AudioSource>();
        
        
    }

    public void playSlotSound()
    {
        audioSource_slotAudio.clip = slotAudioClip;
        audioSource_slotAudio.Play();
    }

    
    public void pauseSlotSound()
    {
        audioSource_slotAudio.clip = slotAudioClip;
        audioSource_slotAudio.Pause();
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
