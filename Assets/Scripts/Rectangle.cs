using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Rectangle : MyShape
{
    private void Start()
    {
        degrees = 10.0f;
    }

    // POLYMORPHISM
    public override void RotateTo()
    {
        transform.Rotate(RotationVector(Vector3.up)); ;
    }
}
