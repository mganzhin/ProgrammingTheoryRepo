using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyShape : MonoBehaviour
{
    // ENCAPSULATION
    private float m_degrees;
    public float degrees
    {
        get
        {
            return m_degrees;
        }

        set
        {
            if (value > 0)
            {
                m_degrees = value;
            }
        }
    }

    // ABSTRACTION
    protected Vector3 RotationVector(Vector3 axe)
    {
        return axe * Time.deltaTime * degrees;
    }

    public virtual void RotateTo()
    {
        m_degrees = 1.0f;
    }

}
