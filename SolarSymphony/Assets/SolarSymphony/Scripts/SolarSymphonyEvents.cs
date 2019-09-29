using System;
using UnityEngine.Events;

public class TriggerSoundEvent : UnityEvent<Planet> { }

public class SolarSymphonyEvents
{
    private TriggerSoundEvent _triggerSound;

    public TriggerSoundEvent TriggerSound { get => _triggerSound; set => _triggerSound = value; }
    
    public SolarSymphonyEvents()
    {
        TriggerSound = new TriggerSoundEvent();
        TriggerSound.AddListener(PlanetTrigger);
    }


    public void PlanetTrigger(Planet planet)
    {
        UnityEngine.Debug.Log(planet);
        //SolarSymphony.Instance.AudioController.Play(sound);
    }
}