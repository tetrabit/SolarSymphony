using UnityEditor;
using UnityEngine;

public class PlanetLight : MonoBehaviour
{
    private float valToBeLerped = 0f;
    private float speed = 20f;
    private float tParam = 0f;
    private float _intensityMin = 40f;
    private float _intensityMax = 80f;

    [SerializeField]
    private Planet _planet;

    private bool _lightEffect;
    private bool _lightEffectReverse;

    public Planet Planet { get => _planet; set => _planet = value; }

    private Component halo;

    void Start()
    {
        halo = gameObject.GetComponent("Halo");
        Debug.Log(halo.GetType().GetProperty("size"));
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
        //halo.GetType().GetProperty("m_Size").SetValue(halo, 40, null);
        //halo = new SerializedObject(gameObject.GetComponent("Halo"));
        //halo.FindProperty("m_Size").floatValue = 40;
        //halo.ApplyModifiedProperties();
        //valToBeLerped = halo.FindProperty("m_Size").floatValue;
    }

    private void Update()
    {

        //float valToBeLerped = halo.FindProperty("m_Size").floatValue;

        if(_lightEffect == true)
        {
            if (tParam < 1)
            {
                tParam += Time.deltaTime * speed; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
                valToBeLerped = Mathf.Lerp(_intensityMin, _intensityMax, tParam);
            }

            if(valToBeLerped == _intensityMax)
            {
                _lightEffect = false;
                _lightEffectReverse = true;
                tParam = 0f;
                halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
            }

            //Debug.Log(valToBeLerped);
            halo.GetType().GetProperty("m_Size").SetValue(halo, valToBeLerped);

            //halo.FindProperty("m_Size").floatValue = valToBeLerped;
            //halo.ApplyModifiedProperties();
        }

        if (_lightEffectReverse)
        {
            if (tParam < 1)
            {
                tParam += Time.deltaTime * speed; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
                valToBeLerped = Mathf.Lerp(_intensityMax, _intensityMin, tParam);
            }

            if (valToBeLerped == _intensityMin)
            {
                _lightEffect = false;
                _lightEffectReverse = false;
                halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
            }

            //halo.FindProperty("m_Size").floatValue = valToBeLerped;
            //halo.ApplyModifiedProperties();

            halo.GetType().GetProperty("m_Size").SetValue(halo, valToBeLerped);
        }
    }
    public void TriggerLightEffect()
    {
        tParam = 0;
        _lightEffect = true;
    }
}
