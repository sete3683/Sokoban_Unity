using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotate : MonoBehaviour
{
    [SerializeField] private float wallRotateSpeed = 1;
    private Rigidbody wallRigidbody;

    void Start()
    {
        wallRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        wallRigidbody.MoveRotation(wallRigidbody.rotation * Quaternion.Euler(new Vector3(0, wallRotateSpeed, 0)));
    }
}
