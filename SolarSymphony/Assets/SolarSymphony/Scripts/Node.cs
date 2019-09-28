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
    private bool _filled;
    [SerializeField]
    private Note _note;
    [SerializeField]
    private CircleCollider2D _dropCollider;

    public bool Filled { get => _filled; set => _filled = value; }
    public Note Note { get => _note; set => _note = value; }
    public CircleCollider2D Collider { get => _dropCollider; set => _dropCollider = value; }
}
