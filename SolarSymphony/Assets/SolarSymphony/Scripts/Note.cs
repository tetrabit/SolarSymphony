using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField]
    private Sound _sound;

    public Sound Sound { get => _sound; set => _sound = value; }
}
