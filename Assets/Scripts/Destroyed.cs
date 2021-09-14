using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    public AudioCollection audioCollect;
    public GameObject DestroyedEffect;
   

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Instantiate(DestroyedEffect, transform.position, Quaternion.identity);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 2f, ForceMode2D.Impulse);
            gameObject.GetComponentInParent<Enemy>().dying();
            audioCollect.PlayKillSound();
        }

    }


}
