using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolume : MonoBehaviour
{
    public static bool GameIsPaused = false;

    AudioSource source;

    float slider;

    void Start()
    {
        //Initiate the Slider value to half way
        slider = 0.25f;
        //Fetch the AudioSource from the GameObject
        source = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        source.Play();
    }

    void Update()
    {
        source.volume = slider;

        if (GameIsPaused == false)
        {
            slider = 0.25f;
        }
        else
        {
            slider = 0.15f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                GameIsPaused = false;
            }
            else
            {
                GameIsPaused = true;
            }
        }
    }
}
