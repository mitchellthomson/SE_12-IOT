using UnityEngine;
using System.Collections;

public class PoleControl : MonoBehaviour
{
    public float moveSpeed;
    // Use this for initialization
    void Start()
    {
        moveSpeed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
    }
}
