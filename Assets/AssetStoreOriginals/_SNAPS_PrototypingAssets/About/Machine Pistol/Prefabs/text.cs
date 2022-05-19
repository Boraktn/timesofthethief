using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fps;
    public GameObject txt;
    int score = 0;
    //public GameObject bulletRemaining;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shooter shooter = fps.GetComponent<shooter>();
        //Debug.Log(shooter.bulletNumber);
        txt.GetComponent<UnityEngine.UI.Text>().text = shooter.bulletNumber.ToString();
        //bulletRemaining.GetComponent<>
    }
}