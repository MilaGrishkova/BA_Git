using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBomb : MonoBehaviour
{
    float speed = 4f;
    float TimeToDisappear = 10f;


    void Start()
    {

     StartCoroutine(Disappear());

    }


    void Update()

    {
     transform.Translate(Vector2.down* speed * Time.deltaTime);
    }

        IEnumerator Disappear()
    {
        yield return new WaitForSeconds(TimeToDisappear);
        gameObject.SetActive(false);
    }

        private void OnCollisionExit2D(Collision2D collision)
    {
        StopCoroutine(Disappear());
        gameObject.SetActive(false);
    }

}

