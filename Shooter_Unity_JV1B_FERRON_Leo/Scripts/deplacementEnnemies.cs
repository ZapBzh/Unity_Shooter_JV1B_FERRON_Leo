using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class deplacementEnnemies : MonoBehaviour
{
    public GameObject bonus;
    public Transform parent;
    public Rigidbody2D monRigidBody;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monRigidBody.velocity = Vector3.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(bonus, parent.position, parent.rotation);

    }
}
