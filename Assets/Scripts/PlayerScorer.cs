using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScorer : MonoBehaviour
{
    private int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (!collision.gameObject.GetComponent<WallHit>().Flag)
                Debug.Log("Player scored: " + ++score);
        }
    }
}
