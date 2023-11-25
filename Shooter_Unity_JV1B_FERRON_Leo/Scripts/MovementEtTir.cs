using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;



    public float speed = 0.03f;
    public float speedMin = 0.01f;
    public float speedMax = 0.03f;
    public bool doubleTir = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(speed);


        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (doubleTir == true)
            {
                Instantiate(bullet, new Vector3(parent.position.x + 0.5f, parent.position.y + 0.5f), parent.rotation);
                Instantiate(bullet, new Vector3(parent.position.x - 0.5f, parent.position.y + 0.5f), parent.rotation);
            }
            
            else{
                Instantiate(bullet, new Vector3(parent.position.x, parent.position.y + 0.5f), parent.rotation);
            }
        }
            
   

        if(transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }

    public void UpdateSpeed(float speedToAdd)
    {
        speed = Mathf.Clamp(speed + speedToAdd, speedMin, speedMax);


    }
}
