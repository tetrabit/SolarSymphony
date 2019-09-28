using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundClip", menuName = "SolarSymphony/Sound/SoundClip")]
public class SoundClip : ScriptableObject
{
    [SerializeField]
    private AudioClip _audioClip;
    [SerializeField]
    private Sound _sound;

    public AudioClip AudioClip { get => _audioClip; set => _audioClip = value; }
    public Sound Sound { get => _sound; set => _sound = value; }
}
