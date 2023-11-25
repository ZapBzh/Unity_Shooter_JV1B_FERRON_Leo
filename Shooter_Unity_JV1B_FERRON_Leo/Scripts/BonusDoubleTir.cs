using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BonusDoubleTir : MonoBehaviour
{

    public bool doubleTir = false;
    public MovementEtTir MovementEtTir;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MovementEtTir joueur = collision.gameObject.GetComponent<MovementEtTir>();
        if (joueur != null)
        {
            joueur.doubleTir = true;

        }
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }
}
