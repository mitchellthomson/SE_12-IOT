using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArduinoCube1 : MonoBehaviour {

    string speed;
    string angle;


    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        string test = wrmhlRead1.Instance.arduinoData;

        float data = float.Parse(test);

        transform.rotation = Quaternion.Euler(0, 0, data);
    }

}
