using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsEndGame()) return;
        transform.position += new Vector3(-speedMove, 0, 0) * Time.deltaTime;
    }
}
