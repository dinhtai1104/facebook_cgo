using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tagCollider = collision.tag;
        if (tagCollider == "ScorePoint")
        {
            Debug.Log("Cộng điểm");
            GameManager.Instance.AddScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            Debug.Log("Bird Die");
            GameManager.Instance.EndGame();
        }
    }

}
