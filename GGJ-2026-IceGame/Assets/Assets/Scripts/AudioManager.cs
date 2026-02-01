using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Creates variables to store audio
    public enum SoundType
    {
        GearLower,
        FatigueLower,
        HungerLower,
        BodyWarmthLower,
        Movement,
        CrackingIce,
        Groan,
        Fire,
        Falling,
        Bear,
    }

    // Creates a system to edit audio volume
    [System.Serializable]
    public class Sound
    {
        public SoundType type;
        public AudioClip clip;

        [Range(0f, 1f)]
        public float volume = 1f;

        [HideInInspector]
        public AudioSource source;
    }

    //Creates a singleton
    public static AudioManager instance;

    // Allows all sounds of the associated type to be set in the Inspector
    public Sound[] allSounds;

    //Runtime collections
    private Dictionary<SoundType, Sound> _soundDictionary = new Dictionary<SoundType, Sound>();

    private void Awake()
    {
        //Assigns the singleton
        instance = this;

        //Sets up sounds
        foreach (var s in allSounds)
        {
            _soundDictionary[s.type] = s;
        }
    }



    // Allows for sounds to actually be played
    public void Play(SoundType type)
    {
        // Useful if an incorrect/invalid sound is called by mistake
        if (!_soundDictionary.TryGetValue(type, out Sound s))
        {
            Debug.LogWarning($"Sound type {type} not found!");
            return;
        }

        //Creates a new sound object
        var soundObj = new GameObject($"Sound_{type}");
        var audioSrc = soundObj.AddComponent<AudioSource>();

        //Assigns your sound properties
        audioSrc.clip = s.clip;
        audioSrc.volume = s.volume;

        //Plays the sound
        audioSrc.Play();

        //Destroys the object
        Destroy(soundObj, s.clip.length);
    }

    // You know what you're doing so feel free not to use this if you don't want to, but if you do use "AudioManager.instance.Play(AudioManager.SoundType.whatever the sounds name in the list is);" where you want the sound effect to be played
}
