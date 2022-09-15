using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSlide : MonoBehaviour
{
    [SerializeField] private float wallSlideSpeed = 1;
    private Rigidbody wallRigidbody;
    private float lastSlideTime = 0;
    private bool canSlide = false;

    void Start()
    {
        wallRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float time = Time.time;

        if (time - lastSlideTime >= 3)
        {
            lastSlideTime = time;
            canSlide = true;
        }
    }

    void FixedUpdate()
    {
        if (canSlide)
        {
            wallRigidbody.AddForce(new Vector3(wallSlideSpeed, 0, 0), ForceMode.VelocityChange);
            wallSlideSpeed *= -1;
            canSlide = false;
        }
    }
}
