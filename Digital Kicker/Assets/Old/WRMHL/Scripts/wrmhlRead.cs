using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class wrmhlRead : MonoBehaviour {

	wrmhl myDevice = new wrmhl(); // wrmhl is the bridge beetwen your computer and hardware.

    public static wrmhlRead Instance;

	[Tooltip("SerialPort of your device.")]
	public string portName = "COM8";

	[Tooltip("Baudrate")]
	public int baudRate = 250000;

	[Tooltip("Timeout")]
	public int ReadTimeout = 20;

	[Tooltip("QueueLenght")]
	public int QueueLenght = 1;

    public string arduinoData;
    public string arduinoDistance;
    public string arduinoAngle;
    public string tempData;

    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

    void Start () {
        
		myDevice.set (portName, baudRate, ReadTimeout, QueueLenght); // This method set the communication with the following vars;
		//                              Serial Port, Baud Rates, Read Timeout and QueueLenght.
		myDevice.connect (); // This method open the Serial communication with the vars previously given.
	}

    // Update is called once per frame


    public void Update()
    {
            arduinoData = myDevice.readQueue();
            tempData = arduinoData;
             
            
}
    void OnApplicationQuit() { // close the Thread and Serial Port
		myDevice.close();
	}


}

