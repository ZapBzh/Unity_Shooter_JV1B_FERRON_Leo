using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalusVit : MonoBehaviour
{
    
    public float speedBonus = -0.01f;
    public MovementEtTir MovementEtTir;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MovementEtTir joueur = collision.gameObject.GetComponent<MovementEtTir>();
        if (joueur != null)
        {
            joueur.UpdateSpeed(speedBonus);
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
