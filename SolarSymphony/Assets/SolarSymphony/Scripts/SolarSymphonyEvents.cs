using UnityEngine.Events;

public class TriggerSoundEvent : UnityEvent<Sound, Planet> { }

public class SolarSymphonyEvents
{
    private TriggerSoundEvent _triggerSound;

    public SolarSymphonyEvents()
    {
        _triggerSound = new TriggerSoundEvent();
        _triggerSound.AddListener(TriggerSound);
    }

    public void TriggerSound(Sound sound, Planet planet)
    {
        SolarSymphony.Instance.AudioController.Play(sound);
    }
}