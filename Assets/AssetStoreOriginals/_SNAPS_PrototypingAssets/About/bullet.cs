using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherObj;
    void Start()
    {
        //Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), GetComponent<Collider>(), true);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5f);
    }
    void OnCollisionEnter(Collision otherObj)
    {

        if (otherObj.gameObject.tag == "Destroyable")
        {
            //Destroy(otherObj.gameObject, .5f); //destroy after a short time delay
            Destroy(gameObject, 0.1f);

        }
    }
}
     
