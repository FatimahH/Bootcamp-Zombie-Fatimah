using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    //this is a value we can access in the Unity Editor that allows us to give a time (in seconds) to countdown from
    [SerializeField] private float TimeToCountDown = 2.5f;

    //this will let us keep track of the time
    private float timer;

    private bool timerStarted;

    // Start is called before the first frame update
    void Start()
    {
        //set the initial value of timer to the value of TimeToCountDown
        timer = TimeToCountDown;
        timerStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer <= 0)
        {
            StopTimer();
        }

        if(Input.GetKeyDown(KeyCode.X) && !timerStarted)
        {
            StartTimer();
        }

        if (timerStarted)
        {
            //remove Time.deltaTime from timer each frame
            timer -= Time.deltaTime;
            //print out the results, so we can see what's going on
            Debug.Log($"timer is {timer}, and time since last frame is {Time.deltaTime}");
        }

    }

    private void StartTimer()
    {
        timerStarted = true;
    }

    private void StopTimer()
    {
        timerStarted = false;
    }
}
