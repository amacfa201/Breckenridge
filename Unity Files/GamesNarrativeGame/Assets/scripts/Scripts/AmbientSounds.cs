using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSounds : MonoBehaviour {

    public string[] soundNames;
    float nextSoundTime;
    float currentTime;
    public float minChance;
    public float maxChance;
    public int randSoundNum;
    public int one_in_x_infrasound_Chance;
    bool doOnce;
    public bool isPlaying;
    AudioManager audioManager;


    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        ResetTime(); // Setting initial values
       
    }

    void Update() {

       
        currentTime += Time.deltaTime;

        if (currentTime > nextSoundTime)
        {
            randSoundNum = Random.Range(0, soundNames.Length);
            if (randSoundNum == 0)
            {
                CheckInfrasound();
                ResetTime();
            }
            else
            {
                if (!audioManager.ambientSound) {
                    audioManager.PlayAmbient(soundNames[randSoundNum]);
                    isPlaying = true;
                    ResetTime();
                }
            }
        }
    }


    public void ResetTime()
    {
        currentTime = 0;
        nextSoundTime = Random.Range(minChance, maxChance);
        doOnce = false;
        audioManager.ambientSound = false;
    }


    public void CheckInfrasound()
    {
        if (!doOnce)
        {

            int infrasoundChance = Random.Range(1, one_in_x_infrasound_Chance);

            if (infrasoundChance == 1)
            {
               
                
                    audioManager.PlayInfrasound("Infrasound");
                
            }

            doOnce = true;
        }
    }
}
