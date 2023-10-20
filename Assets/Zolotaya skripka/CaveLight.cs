using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveLight : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Nogloballight???";
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        List<Collider2D> colliders = new();
        //Physics2D.OverlapCircleAll(transform.position, )
        
        foreach (Collider2D collider in colliders)
            if (collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "Nogloballight???")
                return;


        collision.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
    }
}
