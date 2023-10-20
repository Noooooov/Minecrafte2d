using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dvigatel : MonoBehaviour
{
    [SerializeField] float Skorost;
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            Vector2 dvij = new Vector2(x, y);
            transform.Translate(-dvij * Time.deltaTime * Skorost);
        }
    }
}
