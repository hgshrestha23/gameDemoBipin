using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_btn : MonoBehaviour
{
    public AudioSource audioSource_btn;
    public AudioClip audioClip_btn;
    // Start is called before the first frame update
    void Start()
    {
        audioSource_btn = GetComponent<AudioSource>();
    }

    public void btn_pressSound()
    {
        audioSource_btn.clip = audioClip_btn;
        audioSource_btn.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
