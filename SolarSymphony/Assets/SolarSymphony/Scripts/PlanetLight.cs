using UnityEditor;
using UnityEngine;

public class PlanetLight : MonoBehaviour
{
    [SerializeField]
    private Planet _planet;

    public Planet Planet { get => _planet; set => _planet = value; }

    void Start()
    {
        SerializedObject halo = new SerializedObject(gameObject.GetComponent("Halo"));
        halo.FindProperty("m_Size").floatValue = 100;
        halo.ApplyModifiedProperties();
    }
}
