using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlanetHaloControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] PlanetLight;

    [SerializeField]
    private PlanetLight[] _planetLights;

    private int numPlanets;
    //private Halo[] PlanetHalo;
    //[SerializeField] private bool _isEnabled = true;
    //[SerializeField] private Color _color = Color.red;
    [SerializeField] private float _size = 1;

    public PlanetLight[] PlanetLights { get => _planetLights; set => _planetLights = value; }

    void Start()
    {
        //numPlanets = PlanetLights.Length;

        //for(int x = 0; x < PlanetLights.Length; x++ )
        //{
        //    SerializedObject halo = new SerializedObject(PlanetLight[x].GetComponent("Halo"));
        //    halo.FindProperty("m_Size").floatValue =100;
        //    //halo.FindProperty("m_Enabled").boolValue = _isEnabled;
        //    //halo.FindProperty("m_Color").colorValue = _color;
        //    halo.ApplyModifiedProperties();

        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {

            TriggerHaloEffect(Planet.Mercury);
            TriggerHaloEffect(Planet.Venus);
            TriggerHaloEffect(Planet.Earth);
            TriggerHaloEffect(Planet.Mars);
            TriggerHaloEffect(Planet.Jupiter);
            TriggerHaloEffect(Planet.Saturn);
            TriggerHaloEffect(Planet.Uranus);
            TriggerHaloEffect(Planet.Neptune);

        }
    }

    public void TriggerHaloEffect(Planet planet)
    {
        for (int i = 0; i < PlanetLights.Length; i++)
        {
            if(PlanetLights[i].Planet == planet)
            {
                SerializedObject halo = new SerializedObject(PlanetLight[i].GetComponent("Halo"));
                halo.FindProperty("m_Size").floatValue = 40;
                //halo.FindProperty("m_Enabled").boolValue = _isEnabled;
                //halo.FindProperty("m_Color").colorValue = _color;
                halo.ApplyModifiedProperties();
                PlanetLights[i].TriggerLightEffect();
            }

        }

    }
    
    void PlayPlanetSound(Planet planet)
    {

    }
}
