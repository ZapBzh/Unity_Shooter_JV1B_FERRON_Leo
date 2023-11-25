using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_test : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;
    public GameObject Capsule;
    public float vieEnnemie1;
    public float vieEnnemie2;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ennemie1")
        {
            vieEnnemie1 = vieEnnemie1 - 1;
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
        }

        if (collision.gameObject.tag == "ennemie2")
        {
            vieEnnemie1 = vieEnnemie1 - 1;
            //Destroy(collision.gameObject);
            //Destroy(gameObject);

        }

        if (vieEnnemie1 == 0)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (vieEnnemie2 == 0)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}