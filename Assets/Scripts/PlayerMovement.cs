using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int playerSpeed = 1;
    private Rigidbody playerRigidbody;
    private Vector3 playerForce;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal") * playerSpeed;
        float zSpeed = Input.GetAxis("Vertical") * playerSpeed;

        playerForce = new Vector3(xSpeed, 0, zSpeed);
    }

    void FixedUpdate()
    {
        playerRigidbody.AddForce(playerForce);
    }
}
