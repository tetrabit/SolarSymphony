using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    /// <summary>
    /// TODO
    /// 
    /// collider for drag and drop mechanic
    /// collider for staff note hit mechanic
    /// 
    /// </summary>
    [SerializeField]
    private bool _active;
    [SerializeField]
    private Note _note;
    //[SerializeField]
    //private CircleCollider2D _dropCollider;

    public bool Active { get => _active; set => _active = value; }
    public Note Note { get => _note; set => _note = value; }
    //public CircleCollider2D Collider { get => _dropCollider; set => _dropCollider = value; }

    public void Play()
    {
        SolarSymphony.Instance.AudioController.Play(SolarSymphony.Instance.SoundLibrary.Library[Note.Sound]);
    }
}
