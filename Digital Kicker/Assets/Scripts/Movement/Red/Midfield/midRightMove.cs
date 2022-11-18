using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midRightMove : MonoBehaviour {

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
        transform.Translate(0f, 0f, zMove);

        // initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;
        // Now we can manipulte it to clamp the y element
        clampedPosition.z = Mathf.Clamp(transform.position.z, 3.14f, 22.28f);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;

        transform.Rotate(0f, 0f, moveSpeedr * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
