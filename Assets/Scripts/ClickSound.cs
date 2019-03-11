using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour {

    [SerializeField]
    private AudioManager audioManager;

    [SerializeField]
    private string name;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void Play()
    {
        audioManager.PlaySound(name);
    }
}
