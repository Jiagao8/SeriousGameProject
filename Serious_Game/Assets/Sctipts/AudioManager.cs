using System.Collections.Generic;  
using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    

    void Awake ()
    {
        foreach (Sound s in sounds) 
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            //s.source.outputAudioGroup = s.group;
            
            s.source.loop = s.loop;
            
        }
    }
    /*void Start() {
        Play("opening_sound");
    }
    */
    public void Play (string name) 
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
