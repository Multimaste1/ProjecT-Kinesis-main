using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

     void Awake()
    {
        foreach(Sound soundtoPlay in sounds) //goes through each Sound in sound list and adds an audiosource component to it
        {
           soundtoPlay.source = gameObject.AddComponent<AudioSource>(); //the AudioSource of the sound to play is added to the AudioManager Gameobject
            soundtoPlay.source.clip = soundtoPlay.currentClip; //audioclip to play is set to current clip held in the sound class

            soundtoPlay.source.volume = soundtoPlay.volume; //volume and sliders of AudioSource are changed in the inspector
            soundtoPlay.source.pitch = soundtoPlay.pitch;
        }
    }

    void Start() //sounds to start at start of scene
    {
        playSound("Background"); 
    }
    public void playSound(string SoundName) //function to play sound, parameter of soundName is passed
    {
        Sound s = Array.Find(sounds, sound => sound.soundName == SoundName); //Array is searched to find sound with SoundName and stores this as a sound called "s"
        s.source.Play(); //sounds "s" audiosource plays it
        
    }
}
