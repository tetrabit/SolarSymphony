using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLibrary
{
    private Dictionary<Sound, AudioClip> _library;

    public Dictionary<Sound, AudioClip> Library { get => _library; set => _library = value; }

    public SoundLibrary()
    {
        _library = new Dictionary<Sound, AudioClip>();
        SoundClip temp = ScriptableObject.CreateInstance<SoundClip>();
        for (int i = 1; i < Enum.GetNames(typeof(Sound)).Length; i++)
        {
            temp = Resources.Load<SoundClip>("SoundClips/" + Enum.GetNames(typeof(Sound))[i].ToString());
            _library.Add(temp.Sound, temp.AudioClip);
        }
    }

}
