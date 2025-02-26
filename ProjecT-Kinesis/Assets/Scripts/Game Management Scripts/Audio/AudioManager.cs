using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

     void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach(Sound soundtoPlay in sounds) //goes through each Sound in sound list and adds an audiosource component to it
        {
           soundtoPlay.source = gameObject.AddComponent<AudioSource>(); //the AudioSource of the sound to play is added to the AudioManager Gameobject
            soundtoPlay.source.clip = soundtoPlay.currentClip; //audioclip to play is set to current clip held in the sound class

            soundtoPlay.source.volume = soundtoPlay.volume; //volume and sliders of AudioSource are changed in the inspector
            soundtoPlay.source.pitch = soundtoPlay.pitch;
            soundtoPlay.source.loop = soundtoPlay.loop; //bool for whether sound should loop or not
            soundtoPlay.source.playOnAwake = soundtoPlay.playOnAwake; //bool for whether sound should play when audiomanager is enabled
        } 
    }

    void Start() //sounds to start at start of scene
    {
        playSound("Background"); 
    }
    public void playSound(string SoundName) //function to play sound, parameter of soundName is passed
    {
        Sound s = Array.Find(sounds, sound => sound.soundName == SoundName); //Array is searched to find sound with SoundName and stores this as a sound called "s"

        if (PauseMenu.GameIsPaused)
        {
            s.source.pitch *= 5;
        }
        s.source.Play(); //sounds "s" audiosource plays it
        
    }
}
