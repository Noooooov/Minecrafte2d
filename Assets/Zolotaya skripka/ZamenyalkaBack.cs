using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zamenyalka : MonoBehaviour
{
    public GameObject niga;
    private void Start()
    {
        Instantiate(niga, transform.position, niga.transform.rotation); 
    }
}
