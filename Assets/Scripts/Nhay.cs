using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nhay : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*
            if (Bấm phím cách)
            thì 
            {
                con chim sẽ bay lên
            }
         */
        bool isTap = Input.GetKeyDown(KeyCode.Space);
        if (isTap)
        {
            Debug.Log("Đã bấm phím cách");
            myBody.velocity = new Vector2(0, jumpForce);
            // old: 0, 0 + (0, 10) => (0,10)
        }
    }
}
