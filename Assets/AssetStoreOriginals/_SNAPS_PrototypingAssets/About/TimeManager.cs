using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ProgressBar ProgressBar;
    //public bool Flag = false;
    public bool Flagtemp = false;
    public float slowdownFactor = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == slowdownFactor)
        {
            ProgressBar.decreaseProgress(0.001f);
            //Debug.Log("2");
        }
        else ProgressBar.decreaseProgress(-0.45f);
    }
    public void DoSlowMotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale*0.02f;
        Flagtemp = true;
    }
    public void StopSlowMotion()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.timeScale*0.02f;
        Flagtemp = false;
    }
}
