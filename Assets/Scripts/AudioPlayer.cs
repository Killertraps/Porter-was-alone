using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public GameObject boxes;
    AudioSource hitSound;
    private void Start()
    {
        hitSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (boxes.gameObject.GetComponent<BoxCollider2D>().enabled = true)
        {
            hitSound.Play();
        }
    }
}
