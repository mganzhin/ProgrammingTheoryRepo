using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Square : MyShape
{
    private void Start()
    {
        degrees = 45.0f;
    }

    // POLYMORPHISM
    public override void RotateTo()
    {
        //degrees = 45.0f * Time.deltaTime;
        transform.Rotate(RotationVector(Vector3.right));
    }
}
