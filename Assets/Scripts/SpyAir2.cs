using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyAir2 : MonoBehaviour
{
    //https://www.youtube.com/watch?v=QxKcO0q7GR4
    //https://www.youtube.com/watch?v=22PZJlpDkPE
    //https://www.youtube.com/watch?v=lHLZxd0O6XY


    public float speed = 2f;
    public float restTime = 3f;
    bool Go = true;
    int i = 1;
    public Transform[] turnpoints;

    void Start()
    {
        gameObject.transform.position = new Vector3(turnpoints[0].position.x, turnpoints[0].position.y, transform.position.z);
    }


    void Update()
    {
        if (Go)
            transform.position = Vector3.MoveTowards(transform.position, turnpoints[i].position, speed * Time.deltaTime);

        if (transform.position == turnpoints[i].position)
        {
            if (i < turnpoints.Length - 1)
                i++;
            else
                i = 0;
            Go = false;
            StartCoroutine(Rest());
        }
    }

    IEnumerator Rest()
    {
        yield return new WaitForSeconds(restTime);
        Go = true;
    }
}


