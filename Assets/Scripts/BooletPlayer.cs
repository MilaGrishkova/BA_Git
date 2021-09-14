using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooletPlayer : MonoBehaviour
{

    public float speed = 15f;
    public Rigidbody2D rigidbody;



    private void FixedUpdate()
    {

        rigidbody.velocity = transform.right * speed;

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Player")
        
            {

            Destroy(gameObject);

            }
       
    }
}

