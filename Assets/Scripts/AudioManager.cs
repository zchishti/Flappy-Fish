using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

	// Use this for initialization
	void Start () {
		
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }

	}
	
    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound " + name +" not found");
            return;
        }
        else
        {
            s.source.Play();
        }
    }
}
