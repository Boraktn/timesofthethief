using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class Play : MonoBehaviour, IPointerClickHandler
{
    //public Texture onRed, offGreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    public void OnPointerClick(PointerEventData eventData) {
        SceneManager.LoadScene("SampleScene");
    }

}