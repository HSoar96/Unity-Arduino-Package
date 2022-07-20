using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDChanger : MonoBehaviour
{
    public SerialCommunicationManager communicationManager;

    private void Update()
    {
#if UNITY_ARDUINO_API_SET
        if (Input.GetKeyDown(KeyCode.W))
            communicationManager.SerialWriteLine("LED ON");
        
        if (Input.GetKeyDown(KeyCode.S))
            communicationManager.SerialWriteLine("LED OFF");
#endif
    }
}