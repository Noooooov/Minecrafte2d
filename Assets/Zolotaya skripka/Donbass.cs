using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donbass : MonoBehaviour
{
    [SerializeField] Collider2D ExpTrigger;
    private List<Collider2D> Obj = new List<Collider2D>();
    [SerializeField] int Sila;

    [SerializeField] AudioClip audiosource;
    void Start()
    {

    }

    void Update()
    {

    }

    public void detonate()
    {
        ExpTrigger.Overlap(new ContactFilter2D(), Obj);
        foreach (var item in Obj)
        {
            Rigidbody2D Fiz = item.gameObject.GetComponent<Rigidbody2D>();
            if (Fiz)
            {
                Fiz.bodyType = RigidbodyType2D.Dynamic;
                Vector2 Napr = (item.transform.position - transform.position).normalized;
                Fiz.AddForce(Napr * Sila, ForceMode2D.Impulse);
            }
            if (item.gameObject.TryGetComponent(out Donbass dinamit))
            {
               //dinamit.detonate();
            }
        }
        Camera.main.GetComponent<AudioSource>().PlayOneShot(audiosource);

    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ExpTrigger.enabled = true;
            detonate();
            Destroy(gameObject);
        }
    }
}
