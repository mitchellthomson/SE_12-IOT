using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
    
    Vector3 dims;
    
	void Start () {
        
        //dims = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Screen.height));
        
        transform.localScale = new Vector3(4.8f, 1, 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
