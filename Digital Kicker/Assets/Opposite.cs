using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opposite : MonoBehaviour
{

    public float moveSpeed;
    public float moveSpeedr;
    public float start;

    void Start()
    {
        moveSpeed = 50f;
        moveSpeedr = 800f;
        start = 12.71f;
    }

    // Update is called once per frame
    void Update()
    {
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(zMove, 0f, 0f);


        transform.Rotate((moveSpeedr * Input.GetAxis("Horizontal") * Time.deltaTime) * -1f, 0f, 0f);
    }
}