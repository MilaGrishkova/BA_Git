using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{

    public GameObject[] block;
    public Sprite btnDown;
    public AudioCollection audioCollect;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MarkBox") {
            
            GetComponent<SpriteRenderer>().sprite = btnDown;
            GetComponent<CircleCollider2D>().enabled = false;
            foreach (GameObject obj in block)
            {
                
                Destroy(obj);
                
            }

            audioCollect.GetComponent<AudioCollection>().PlayMarkBox();
        }
    }
}
