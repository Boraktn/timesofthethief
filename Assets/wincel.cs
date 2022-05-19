using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wincel : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 100.0f;
    public Text textHints;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            textHints.SendMessage("ShowHint","YOU WIN");
            
        }
    }
}
