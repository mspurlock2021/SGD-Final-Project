using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDelay : MonoBehaviour
{
    public float start;
    public float end;
    float time;

    public void Start()
    {
        time = start;
    }

    public void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            GetComponent<AudioSource>().Play();
            time = end;
        }
    }
}
