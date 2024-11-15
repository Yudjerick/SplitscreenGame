using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingComponent : MonoBehaviour
{
    [field: SerializeField] public float AngularVelocity = 60f;
    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(new Vector3(0,0,AngularVelocity) * Time.deltaTime);
    }

    public Vector2 GetDirection()
    {
        return transform.up;
    }
}
