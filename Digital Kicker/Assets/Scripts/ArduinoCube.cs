using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArduinoCube : MonoBehaviour {

    // Use this for initialization
    void Start () {
   
    }

	// Update is called once per frame
	void Update () {


        string data = wrmhlRead.Instance.tempData;


        string angle;
        string distance;
        int i=  data.IndexOf(",");
        int len = data.Length;
        int n = i + 1;
        int m = i - 1;
        angle = data.Substring(0, i);
        print(angle);

        distance = data.Substring(n,len-n);

        print(distance);

        float angledata = float.Parse(angle);
        float distdata = float.Parse(distance);

        transform.rotation = Quaternion.Euler(0, 0, angledata);

        transform.position = new Vector3(-48.97f, .36f, distdata -35);

        //for rotation
        /*
        string angle = wrmhlRead.Instance.arduinoAngle;
        int angleLen = angle.Length;
        print(angleLen);
        print(angle);

        float data = float.Parse(angle);
        data = data * -1;

        transform.rotation = Quaternion.Euler(0, 0, data);
        
        */
        // string distance = wrmhlRead.Instance.arduinoDistance;
        //float datadis = float.Parse(distance);

        // transform.position = new Vector3(-19, 0, datadis);
    }
    
}