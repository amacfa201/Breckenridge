using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;
    public bool ambientSound;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)
        {
            print("Oops: Maybe a spelling eroor??: " + name + " was not found");
        }
        s.source.Play();

    }


    public void PlayAmbient(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)
        {
            print("Oops: Maybe a spelling eroor??: " + name + " was not found");
        }

        s.source.Play();
        ambientSound = true;
    }

    public void PlayInfrasound(string name)
    {
        float currentTime = 0.0f;
        float limit = UnityEngine.Random.Range(0.25f, 0.75f);
        currentTime += Time.deltaTime;
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)
        {
            print("Oops: Maybe a spelling eroor??: " + name + " was not found");
        }

        s.source.time = UnityEngine.Random.Range(0, s.source.clip.length);
        s.source.Play();


        if (currentTime > limit)
        {
            s.source.Stop();

        }
    }


}
