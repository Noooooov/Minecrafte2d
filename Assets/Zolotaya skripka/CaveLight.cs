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
        Collider2D[] stolks = Physics2D.OverlapCircleAll(collision.transform.position, 2);
        
        foreach (Collider2D collider in stolks)
            if (collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "Nogloballight???")
                return;


        collision.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
    }
}
