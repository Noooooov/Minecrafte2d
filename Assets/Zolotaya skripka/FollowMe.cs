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
       
        Fizika.velocity = dir*35 ;
    }

    private void CheckLight()
    {
        if (selfCollider != null)
        {
            List<Collider2D> overlapColliders = new List<Collider2D>();
            selfCollider.Overlap(overlapColliders);

            foreach (Collider2D collider in overlapColliders)
                if (collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "Nogloballight???")
                {
                    spriteRenderer.sortingLayerName = "Nogloballight???";
                    return;
                }

            spriteRenderer.sortingLayerName = "Default???";

        }
    }
    private void FixedUpdate()
    {
        CheckLight();
    }
}
