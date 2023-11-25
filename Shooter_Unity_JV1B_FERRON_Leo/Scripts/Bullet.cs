using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bonus;
    public Transform parent;
    public Rigidbody2D monRigidBody;
    public Rigidbody2D RBEnnemies;
    public Rigidbody2D RBEnnemies2;
    public float speed;
    
    private  ScoreManageur scoreManageur;
    public float score =0f ;
    
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
        scoreManageur = FindObjectOfType<ScoreManageur>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        scoreManageur.score += 1;
        
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
