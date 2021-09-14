using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroundDetect : MonoBehaviour
{
    //https://www.youtube.com/watch?v=aRxuKoJH9Y0
    //https://www.youtube.com/watch?v=umpmRxA6CnY
    //https://www.youtube.com/watch?v=MPnN9i1SD6g

    public Transform groundDetect;
    bool moveIt = true;
    public float speed = 3f;
    public AudioSource audioSource;
    public AudioClip turn;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D pointturn = Physics2D.Raycast(groundDetect.position, Vector2.down, 1f);



        if (pointturn.collider == false)
        {
            if (moveIt == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                moveIt = false;
                audioSource.PlayOneShot(turn);
            }

            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveIt = true;
                audioSource.PlayOneShot(turn);
            }
        }
    }
}

