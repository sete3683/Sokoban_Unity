using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{
    private MeshRenderer wallMaterial;
    public bool Flag { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        wallMaterial = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (!Flag && other.gameObject.tag == "Player")
        {
            Debug.Log("Hit by Player:" + name);
            wallMaterial.material.color = Color.red;
            Flag = true;
        }
    }
}
