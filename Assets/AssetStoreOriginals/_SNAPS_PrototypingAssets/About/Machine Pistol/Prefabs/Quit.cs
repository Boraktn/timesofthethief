using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class Quit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Texture onRed, offGreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData) {

        GetComponent<RawImage>().texture = onRed;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }

    public void OnPointerExit(PointerEventData eventData) {
        GetComponent<RawImage>().texture = offGreen;
    }

}