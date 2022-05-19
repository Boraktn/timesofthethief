using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public TimeManager TimeManager;
    public float power;
    public Rigidbody bullet;
    public AudioClip bulletSound;
    public Rigidbody target;
    public GameObject launcher;
    public float rotationSpeed = 2f;
    public float movementSpeed = 0.1f;
    public bool flag = false;
    public float shootingTimer = 200f;
    public Animator anim;
    public shooter shooter;
    //public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {

            RaycastHit hit;
            if (Physics.Raycast(launcher.transform.position, transform.TransformDirection(Vector3.forward), out hit, 50))
            {
                if (hit.collider.gameObject.tag == "Player")
                {
                    if (shootingTimer > 0) shootingTimer -= 1;
                    else
                    {
                        shoot();
                        shootingTimer = 200f;
                    }
                }
            }
        }
    }
    
    public void shoot()
    {
        //GetComponent<AudioSource>().PlayOneShot(bulletSound);
        Rigidbody instance = Instantiate(bullet, launcher.transform.position,
            launcher.transform.rotation) as Rigidbody;
        Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), instance.GetComponent<Collider>(), true);
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (TimeManager.Flagtemp)
        {
            instance.AddForce(fwd * power * 5f);
        }
        else
        {
            instance.AddForce(fwd * power);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        transform.rotation = Quaternion.Slerp(transform.rotation,
     Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
        flag = true;
    }
    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            anim.Play("Robo1 Die",-1, 0.0f);
            //Debug.Log("f");
            // reload.GetComponent
            shooter.bulletNumber += 10;
            Destroy(gameObject, 0.8f);
               }
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(100);
    }
}