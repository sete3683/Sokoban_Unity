using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private float ballBounciness;
    private Rigidbody ballRigidbody;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();

        transform.position = 
            new Vector3(transform.position.x, Random.Range(5, 12), transform.position.z);
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        ballRigidbody.AddForce(new Vector3(0, ballBounciness, 0), ForceMode.Impulse);
    }
}
