using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public float fillSpeed = 0.9f;
    public float targetProgress = 0f;
    // Start is called before the first frame update
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    void Start()
    {

        //decreaseProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value > targetProgress)
        {
            //Debug.Log(Time.deltaTime);
            slider.value = slider.value - fillSpeed * Time.fixedDeltaTime;
        }
        //else
        //{

        //    targetProgress += 0.02f;
        //}
        if (slider.value<targetProgress)
        {
            slider.value = slider.value + 0.1f * Time.fixedDeltaTime;
        }
    }
    public void decreaseProgress(float newProgress)
    {
        targetProgress = slider.value - newProgress;
    }
}