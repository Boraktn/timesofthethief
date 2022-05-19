using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textHints : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Text>().enabled)
        {
            timer += Time.deltaTime;
            if (timer >= 4)
            {
                GetComponent<Text>().enabled = false;
                timer = 0.0f;
            }
        }
    }
    void ShowHint(string message)
    {
        GetComponent<Text>().text = message;
        if (!GetComponent<Text>().enabled)
        {
            GetComponent<Text>().enabled = true;
        }
    }
}
