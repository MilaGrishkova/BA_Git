using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    float timer = 0f;
    float timerHit = 0f;


    void Update()
    {
        //https://www.youtube.com/watch?v=um3iyvGV13Q
        //https://ilhamhe.medium.com/dynamic-2d-water-in-unity-8d897852ee01


        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            timer = 0;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (timer >= 1f)
            transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Player>().inWater = true;
            timerHit += Time.deltaTime;
            if (timerHit >= 2f)
            {
                collision.gameObject.GetComponent<Player>().RecountHeart(-1);
                timerHit = 0;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Player>().inWater = false;
            timerHit = 0;
        }
    }
}
