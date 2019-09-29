using UnityEditor;
using UnityEngine;

public class PlanetLight : MonoBehaviour
{
    private float valToBeLerped = 0f;
    private float speed = 10f;
    private float tParam = 0f;
    private float _intensityMin = 40f;
    private float _intensityMax = 150f;

    [SerializeField]
    private Planet _planet;

    private bool _lightEffect;
    private bool _lightEffectReverse;

    public Planet Planet { get => _planet; set => _planet = value; }

    private SerializedObject halo;
    void Start()
    {
        halo = new SerializedObject(gameObject.GetComponent("Halo"));
        halo.FindProperty("m_Size").floatValue = 40;
        halo.ApplyModifiedProperties();
        valToBeLerped = halo.FindProperty("m_Size").floatValue;
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
            }

            //Debug.Log(valToBeLerped);
            halo.FindProperty("m_Size").floatValue = valToBeLerped;
            halo.ApplyModifiedProperties();
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
            }

            halo.FindProperty("m_Size").floatValue = valToBeLerped;
            halo.ApplyModifiedProperties();
        }
    }
    public void TriggerLightEffect()
    {
        tParam = 0;
        _lightEffect = true;
    }
}
