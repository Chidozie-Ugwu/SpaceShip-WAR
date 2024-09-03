using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    public float initialTimeScale = 1.0f;// Starting speed of the game
    public float maxTimeScale = 5.0f;//MAXIMUN SPEED THE GAME CAN REACH
    public float speedIncreaseRate = 0.5f;// HOW QUICKLY THE SPEED INCREASES OVER TIME
    public float timeToMaxSpeed = 60f;//TIME IN SECONDS TO REACH MAX SPEED
    private float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // SET THE INITIAL TIME SCALE WHEN THE GAME STARTS
        Time.timeScale  =  initialTimeScale;
    }

    // Update is called once per frame
    void Update()
    {
        //INCREMENT ELAPSED TIME BY THE TIME PASSED SINCE THE LAST FRAME
        elapsedTime += Time.deltaTime;
        // CALULATE THE NEW TIME SCALE BASED ON ELAPSED TIME
        float newTimeScale = Mathf.Lerp(initialTimeScale, maxTimeScale,elapsedTime/timeToMaxSpeed);
        //APPLY THE NEW TIME SCALE 
        Time.timeScale = newTimeScale;
        //OPTIONALLY CLAMP THE TIME SCALE TO THE MAX VALUE TO AVOID EXCEEDING IT
        Time.timeScale = Mathf.Clamp(Time.timeScale , initialTimeScale ,maxTimeScale);

    }
    //RESETTING THE TIME SCALE WHEN THE GAME ENDS OR RESET
    void OnDestroy()
    {
        Time.timeScale = 1.0f;
    }
}
