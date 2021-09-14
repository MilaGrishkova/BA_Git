using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyAir1 : MonoBehaviour
{
    public float speed = 2f;
    public float restTime = 3f;
    bool Go = true;
    public Transform turnpoint1;
    public Transform turnpoint2;
    public AudioTurn audioTurn;




    void Start()
    {
        gameObject.transform.position =
        new Vector3(turnpoint1.position.x,
        turnpoint1.position.y, transform.position.z);
    }


    void Update()
    {//https://www.youtube.com/watch?v=AGiRP6e090c
     //https://www.youtube.com/watch?v=QxKcO0q7GR4&t=390s
     //https://www.youtube.com/watch?v=8eWbSN2T8TE
     //https://www.youtube.com/watch?v=MPnN9i1SD6g
     //https://www.youtube.com/watch?v=QxKcO0q7GR4
     //https://www.youtube.com/watch?v=_21eUOhtjK4&t=61s
     //https://www.youtube.com/watch?v=lHLZxd0O6XY 


        if (Go)
        {
            transform.position = Vector3.MoveTowards(transform.position, turnpoint1.position, speed * Time.deltaTime);
        }

        if (transform.position == turnpoint1.position)
        {
            Transform t = turnpoint1;
            turnpoint1 = turnpoint2;
            turnpoint2 = t;
            Go = false;
            StartCoroutine(Rest());
        }
    }

    IEnumerator Rest()
    {
        yield return new WaitForSeconds(restTime);
        if (transform.rotation.y == 0)
        {
            audioTurn.PlayTurnSound();
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else
        {
            audioTurn.PlayTurnSound();
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        Go = true;
    }
}


