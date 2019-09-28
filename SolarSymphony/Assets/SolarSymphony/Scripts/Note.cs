using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Note
{
    [SerializeField]
    private Sound _sound;

    public Sound Sound { get => _sound; set => _sound = value; }
}
