using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public int forward_force ;
    public int sideways_force;
    private double speedup;
    public GameObject collide;

    void Start()
    {
       // Debug.Log("Hello World!!");
       // rb.useGravity = false;
        rb.AddForce(0, 0, 0);
        speedup = 1;
        HitEffect();

      //  Invoke("Update", 4);
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(0, 0, (float)speedup + (forward_force * Time.deltaTime));
        if (Input.GetKey("d"))
        {
           // Instantiate(collide, transform.position, transform.rotation);
            rb.AddForce(sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
           // Instantiate(collide, transform.position, transform.rotation);
            rb.AddForce(-sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //else if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0, sideways_force * Time.deltaTime, 0);
        //}
        //else if (Input.GetKey("s"))
        //{
        //    rb.AddForce(0, -sideways_force * Time.deltaTime, 0);
        //}
        speedup = (double)speedup + 0.008;


    }

    void HitEffect()
    {
        Instantiate(collide, transform.position, transform.rotation);

        Destroy(collide);
    }
}
