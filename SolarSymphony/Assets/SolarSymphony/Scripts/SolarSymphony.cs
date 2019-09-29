using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SolarSymphony : MonoBehaviour
{
    private static SolarSymphony _instance;
    [SerializeField]
    private SoundLibrary _soundLibrary;
    [SerializeField]
    private AudioController _audioController;
    [SerializeField]
    private SolarSymphonyEvents _solarSymphonyEvents;
    [SerializeField]
    private SequencerDriver _sequencerDriver;
    [SerializeField]
    private PlanetHaloControl _planetHaloControl;

    public static SolarSymphony Instance { get => _instance; private set => _instance = value; }
    public SoundLibrary SoundLibrary { get => _soundLibrary; private set => _soundLibrary = value; }
    public AudioController AudioController { get => _audioController; private set => _audioController = value; }
    public SolarSymphonyEvents SolarSymphonyEvents { get => _solarSymphonyEvents; set => _solarSymphonyEvents = value; }
    internal SequencerDriver SequencerDriver { get => _sequencerDriver; set => _sequencerDriver = value; }
    public PlanetHaloControl PlanetHaloControl { get => _planetHaloControl; set => _planetHaloControl = value; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else if (Instance != this)
            Destroy(gameObject);
    }

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        SoundLibrary = new SoundLibrary();
        AudioController = FindObjectOfType<AudioController>();
        SolarSymphonyEvents = new SolarSymphonyEvents();
        SequencerDriver = FindObjectOfType<SequencerDriver>();
        PlanetHaloControl = FindObjectOfType<PlanetHaloControl>();
    }
}

