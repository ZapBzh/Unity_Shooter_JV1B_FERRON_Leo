using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet3 : MonoBehaviour
{
    public GameObject bonus;
    public Transform parent;
    public Rigidbody2D monRigidBody;
    public Rigidbody2D RBEnnemies;
    public Rigidbody2D RBEnnemies2;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
        //monRigidBody.velocity = Vector3.up * speed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        
       
    }


    void Update()
    {
        if (gameObject == null)
        {
            Instantiate(bonus, parent.position, parent.rotation);
            
        }
        
    }
}
