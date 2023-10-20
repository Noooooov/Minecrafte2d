using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class DJ : MonoBehaviour
{
    private AudioSource dj;
    private SpriteRenderer playing;
    private Animator animka;
    void Start()
    {
        dj = GetComponent<AudioSource>();
        playing = GetComponent<SpriteRenderer>();
        animka = GetComponent<Animator>();
    }

    private void Update()
    {
        if (dj.isPlaying == false)
        {
            animka.SetBool("DJ Arbuzeuro", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Music")
        {
            animka.SetBool("DJ Arbuzeuro", true);
            dj.PlayOneShot(collision.gameObject.GetComponent<Plastinka>().music);
            Destroy(collision.gameObject);
        }
    }

}
