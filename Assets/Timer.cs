using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalSeconds = 0;
    float elapsedSeconds = 0;
    bool running = false;
    bool started = false;

    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }
        }
    }

    public bool Finished
    {
        get { return started && !running; }
    }

    public bool Running
    {
        get { return running; }
    }

    void Update()
    {
        // update timer and check for finished
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            if (elapsedSeconds >= totalSeconds)
            {
                running = false;
            }
        }
    }

    public void Run()
    {
        // only run with valid duration
        if (totalSeconds > 0)
        {
            started = true;
            running = true;
        }
    }
}
