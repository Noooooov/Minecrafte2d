using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{
    private Rigidbody2D Fizika;
    private Collider2D selfCollider;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        Fizika= GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        selfCollider = GetComponentInChildren<Collider2D>();
    }

    private void OnEnable()
    {
        Fizika.bodyType = RigidbodyType2D.Dynamic;
        Fizika.gravityScale = 0;
    }

    private void OnDisable()
    {
        Fizika.gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (posMouse - transform.position).normalized;
       
        Fizika.linearVelocity = dir*35 ;
    }
}
