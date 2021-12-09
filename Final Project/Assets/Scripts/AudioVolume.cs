using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolume : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public AudioSource source;

    float slider;

    void Start()
    {
        //Initiate the Slider value to half way
        slider = 0.5f;
        //Fetch the AudioSource from the GameObject
        source = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        source.Play();
    }

    void Update()
    {
        source.volume = slider;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                slider = 0.15f;
                GameIsPaused = true;
            }
            else
            {
                slider = 0.5f;
                GameIsPaused = false;
            }
        }
    }
}
