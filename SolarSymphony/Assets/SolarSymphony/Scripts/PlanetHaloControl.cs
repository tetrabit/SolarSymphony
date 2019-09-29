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
        numPlanets = PlanetLights.Length;
        // x = PlanetLight[numPlanets].GetComponent("Halo");
        //PlanetLight[numPlanets].GetComponent("Halo"). = false;
        for(int x = 0; x < PlanetLights.Length; x++ )
        {
            SerializedObject halo = new SerializedObject(PlanetLight[x].GetComponent("Halo"));
            halo.FindProperty("m_Size").floatValue =100;
            //halo.FindProperty("m_Enabled").boolValue = _isEnabled;
            //halo.FindProperty("m_Color").colorValue = _color;
            halo.ApplyModifiedProperties();



            //PlanetLight[numPlanets].GetComponent<Light>().GetComponent<Halo>().getPr

            //Component halo = PlanetLight[x].GetComponent("Halo");
            //halo.GetType().GetProperty("Size").SetValue(halo, 1000);
            //Debug.Log(halo.GetType());
            //Debug.Log(halo.GetType().GetProperty("Size"));
            //SolarSymphony.Instance.SolarSymphonyEvents.PlanetTrigger(Planet.Earth);
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerHaloEffect(Planet planet)
    {
        for (int i = 0; i < PlanetLights.Length; i++)
        {
            if(PlanetLights[i].Planet == planet)
            {
                //make light effect happen here
            }

        }
    }
    
    void PlayPlanetSound(int planet)
    {

    }
}
