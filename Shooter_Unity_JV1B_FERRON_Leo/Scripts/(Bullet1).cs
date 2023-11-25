using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float pvEnnemies = 2;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        pvEnnemies = pvEnnemies - 1;


        if (pvEnnemies == 0)
        {
            Destroy(gameObject);
        }
    }

}
