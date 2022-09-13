using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int playerSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float zSpeed = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        transform.Translate(xSpeed, 0, zSpeed);
    }
}
