using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float feuerRate = 0.2f;
    public GameObject bulletPlayerPrefab;
    public Transform FeuerPoint;
    float TimeFeuer;
    Player pm;

    void Start()
    {
        pm = gameObject.GetComponent<Player>();
    }


    void Update()
    {
        //gist.github.com/remembern0vember/16242f17ce27a7dd279dbd49111c5297
        //https://www.youtube.com/watch?v=KKgtC_Gy65c&t=823s
        //https://www.youtube.com/watch?v=qQ7V5COPDVk

        if (Input.GetKeyDown(KeyCode.DownArrow) && TimeFeuer < Time.time)
        {
            Shoot();
            TimeFeuer = Time.time + feuerRate;
        }

    }

    void Shoot()
    {

        float angle = pm.isFacingRight ? 0f : 180f;
        Instantiate(bulletPlayerPrefab, FeuerPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }

}