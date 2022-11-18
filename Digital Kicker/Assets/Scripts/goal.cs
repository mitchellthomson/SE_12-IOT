using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goaler : MonoBehaviour {

    public ball ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        ball.Init();
    }
}
