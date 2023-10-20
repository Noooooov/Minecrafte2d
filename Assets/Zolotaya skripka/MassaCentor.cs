using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassaCentor : MonoBehaviour
{
    public Transform CentorM;
    private Rigidbody2D Rig;
    private void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        Rig.centerOfMass = CentorM.localPosition;

    }
}
