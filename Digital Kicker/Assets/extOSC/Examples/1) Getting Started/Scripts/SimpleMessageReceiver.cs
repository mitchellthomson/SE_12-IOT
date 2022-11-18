/* Copyright (c) 2018 ExT (V.Sigalkin) */

using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;

namespace extOSC.Examples
{
    public class SimpleMessageReceiver : MonoBehaviour
    {
        public static SimpleMessageReceiver Instance;
        #region Public Vars

        public string Address = "/example/1";

        [Header("OSC Settings")]
        public OSCReceiver Receiver;
        public OSCMessage message;
        #endregion

        #region Unity Methods

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


        protected virtual void Start()
        {
            Receiver.Bind(Address, ReceivedMessage);
        }

        #endregion

        #region Private Methods

        private void ReceivedMessage(OSCMessage message)
        {
            double angle;
            double distance;
            message.ToDouble(out angle);
            message.ToDoubleTwo(out distance);

            float anglef = (float)angle;

            float distancef = (float)distance;
            print(distancef);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, anglef);
            this.gameObject.transform.position = new Vector3(-48.97f, .36f, distancef - 65);




            #endregion
        }
    }
}