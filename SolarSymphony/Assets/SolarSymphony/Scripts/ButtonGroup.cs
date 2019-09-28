using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonGroup : MonoBehaviour
{
    [SerializeField]
    private Toggle[] _toggles;
    [SerializeField]
    private Planet _planet;

    public Toggle[] Toggles
    {
        get
        {
            return _toggles;
        }

        set
        {
            _toggles = value;
        }
    }

    public Planet Planet { get => _planet; set => _planet = value; }

    private void Start()
    {
        Toggles[0].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[0], 0);
        });

        Toggles[1].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[1], 1);
        });

        Toggles[2].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[2], 2);
        });

        Toggles[3].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[3], 3);
        });

        Toggles[4].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[4], 4);
        });

        Toggles[5].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[5], 5);
        });

        Toggles[6].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[6], 6);
        });

        Toggles[7].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[7], 7);
        });

        Toggles[8].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[8], 8);
        });

        Toggles[9].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[9], 9);
        });

        Toggles[10].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[10], 10);
        });

        Toggles[11].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[11], 11);
        });

        Toggles[12].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[12], 12);
        });

        Toggles[13].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[13], 13);
        });

        Toggles[14].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[14], 14);
        });

        Toggles[15].onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(Toggles[15], 15);
        });
    }

    private void ToggleValueChanged(Toggle change, int iterator)
    {
        SolarSymphony.Instance.SequencerDriver.sequencers[(int)Planet].GetComponent<SequencerGroup>().Sequencers[0].sequence[iterator] = change.isOn;
    }
}
