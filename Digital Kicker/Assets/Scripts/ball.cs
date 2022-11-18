using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    float velocity;
    int i;
    float number;

	// Use this for initialization
	void Start () {
        Init();
	}
	

    public void Init()
    {
        transform.Translate(0f, 0f, 0f);
        transform.SetPositionAndRotation(new Vector3(-33f, 1.15f, -56.5f), new Quaternion(0f, 0f, 0f,0f));
        velocity = .5f;
        number = Random.Range(-.5f, .5f);
        i = 0;

    }

	// Update is called once per frame
	void Update () {
		if (i < 30)
        {
            transform.Translate(0f, 0f, number);
        }
        i = i + 1;
    }
}
