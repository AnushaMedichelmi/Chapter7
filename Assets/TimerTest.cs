using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    Timer timer;

    float startTime;

    void Start()
    {

        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 3;
        timer.Run();
        startTime = Time.time;
    }
    void Update()
    {
        // check for timer just finished
        if (timer.Finished)
        {
            float elapsedTime = Time.time - startTime;
            print("Timer ran for " + elapsedTime + " seconds");
            // save start time and restart timer
            startTime = Time.time;
            timer.Run();
        }
    }
}
