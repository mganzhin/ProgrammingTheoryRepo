using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Stick : MyShape
{

    private void Start()
    {
        degrees = 90.0f;
    }

    // POLYMORPHISM
    public override void RotateTo() {
        transform.Rotate(RotationVector(Vector3.forward));
    }

    
}
