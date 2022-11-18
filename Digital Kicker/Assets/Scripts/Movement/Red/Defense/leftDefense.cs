using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftDefense : MonoBehaviour
{

    public float moveSpeed;
    public float moveSpeedr;
    public float start;
    public GameObject defense;
    void Start()
    {
        moveSpeed = 10f;
        moveSpeedr = 5f;
        start = -12.71f;
    }

    // Update is called once per frame
    void Update()
    {
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(zMove, 0f, 0f);

        // initially, the temporary vector should equal the player's position



        defense = GameObject.Find("KickertableplusPlayers/Players/RED/Defense");

        if (Input.GetMouseButton(0))
        {

            transform.RotateAround(transform.position + new Vector3(0.1468138f, -2.282182e-05f, 0.1665279f), Vector3.left, moveSpeedr);
        }
    }
}
