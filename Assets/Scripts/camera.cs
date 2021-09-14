using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    float speed = 3f;
    public Transform target;

    // https://www.youtube.com/watch?v=C2OBnRyOxL8
    //https://www.youtube.com/watch?v=_QnPY6hw8pA
    void Start()
    {
        transform.position =
        new Vector3(target.transform.position.x,
        target.transform.position.y, transform.position.z);
    }



    void Update()
    {
        Vector3 position = target.position;
        position.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position,
        position, speed * Time.deltaTime);

    }

}
