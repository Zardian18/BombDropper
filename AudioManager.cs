using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource aud;
    [SerializeField]
    AudioClip clip;
    public bool isMuted = false;
    
    
    void Start()
    {
        aud = GetComponent<AudioSource>();
        if (aud != null)
        {
            aud.clip = clip;
            aud.PlayOneShot(clip);
        }
       // uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    
    void Update()
    {
        
    }

    public void ToogleAudio()
    {
        if (aud.isPlaying)
        {
            aud.Pause();
            isMuted = true;
        }
        else
        {
            aud.UnPause();
            isMuted = false;
        }
    }

    public void StopClip()
    {
        aud.Stop();
    }
    public void PlayClip()
    {
        aud.PlayOneShot(clip);
    }
}
