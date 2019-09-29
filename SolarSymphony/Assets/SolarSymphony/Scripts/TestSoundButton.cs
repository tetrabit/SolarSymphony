using UnityEngine;

public class TestSoundButton : MonoBehaviour
{
    [SerializeField]
    private Sound _sound;

    public Sound Sound { get => _sound; set => _sound = value; }

    public void Play()
    {
        SolarSymphony.Instance.AudioController.Play(_sound);
    }
}
