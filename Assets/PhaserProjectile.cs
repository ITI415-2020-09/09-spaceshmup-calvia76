using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaserProjectile : MonoBehaviour
{
    public float MoveSpeed = 50f;

    public float frequency = 20.0f;  // Speed of sine movement
    public float magnitude = 3f;   // Size of sine movement
    private Vector3 axis;

    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        axis = transform.right;  

    }

    void Update()
    {
        pos += transform.up * Time.deltaTime * MoveSpeed;
        transform.position = pos + (axis * Mathf.Sin(Time.time * frequency) * magnitude);
    }

}
