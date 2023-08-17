using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerMovement movement;
    public Gamemanager a;

    public GameObject collide;
    public GameObject collide2;
    private void Start()
    {
        a = FindObjectOfType<Gamemanager>();

    }

    private void OnCollisionEnter(Collision ob)
    {
        if (ob.collider.tag == "obstacle")
        {
            movement.enabled = false;
            HitEffect();
            //FindObjectOfType<Gamemanager>().EndGame();
            a.EndGame();
        }
        else
        {
           // movement.enabled = false;
            Hit2Effect();
            //FindObjectOfType<Gamemanager>().EndGame();
          //  a.EndGame();
        }

    }
    void HitEffect()
    {
        Instantiate(collide, transform.position, transform.rotation);

        Destroy(collide);
    }

    void Hit2Effect()
    {
        Instantiate(collide2, transform.position, transform.rotation);

        Destroy(collide);
    }
}
