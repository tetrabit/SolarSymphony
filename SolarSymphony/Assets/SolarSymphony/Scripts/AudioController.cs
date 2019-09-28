using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;

    public AudioSource AudioSource { get => _audioSource; private set => _audioSource = value; }

    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    public void Play(AudioClip audioClip)
    {
        AudioSource.PlayOneShot(audioClip);
    }
}
