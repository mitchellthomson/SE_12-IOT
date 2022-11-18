using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public float moveSpeedr;
	// Use this for initialization
	void Start () {
        moveSpeed = 20f;
        moveSpeedr = 80f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Rotate(0f, 0f, moveSpeedr * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
