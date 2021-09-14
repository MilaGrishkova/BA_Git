
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    public float FireTime = 4f;
    public GameObject fireBall;
    public Transform firePoint;
    private AudioSource Audio;
    public AudioClip[] AudioClipArray;


    void Awake()
    {
        Audio = GetComponent<AudioSource>();
    }


    void Start()
    {
        firePoint.transform.position =
        new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
        StartCoroutine(Falling());

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BulletPlayer"))

        {
            Destroy(gameObject);
        }
    }

    IEnumerator Falling()
    {
        yield return new WaitForSeconds(FireTime);
        Instantiate(fireBall, firePoint.transform.position, transform.rotation);
        StartCoroutine(Falling());
        Audio.clip = AudioClipArray[Random.Range(0, AudioClipArray.Length)];
        Audio.PlayOneShot(Audio.clip);

    }
}
