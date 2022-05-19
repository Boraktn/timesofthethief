using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Rigidbody bullet;
    public AudioClip bulletSound;
    public float speed;
    //public float range;
    public float power;
    public int bulletNumber;
    public GameObject gun;
    public float timeSlow = 4f;
    public TimeManager TimeManager;
    public ProgressBar ProgressBar;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        bullet.transform.Translate(h, v, 0);
        if (Input.GetButtonUp("Fire1"))
        {
            if (bulletNumber != 0)
            {
                GetComponent<AudioSource>().PlayOneShot(bulletSound);
                Rigidbody instance = Instantiate(bullet, transform.position,
                    transform.rotation) as Rigidbody;
                Physics.IgnoreCollision(transform.parent.root.GetComponent<Collider>(), instance.GetComponent<Collider>(), true);
                Vector3 fwd = transform.TransformDirection(Vector3.forward);
                if (TimeManager.Flagtemp)
                {
                    instance.AddForce(fwd * power * 5f);
                }
                else
                {
                    instance.AddForce(fwd * power);
                }
                //TimeManager.DoSlowMotion();
                bulletNumber = bulletNumber - 1;
                Debug.Log(bulletNumber);
                if (bulletNumber == 0) gun.SetActive(false);
            }

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            TimeManager.DoSlowMotion();
            //Debug.Log("start");
            
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            TimeManager.StopSlowMotion();
            //Debug.Log("stop");
        }
    }
}
