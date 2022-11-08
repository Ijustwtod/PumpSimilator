using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Pump : MonoBehaviour
{
    public GameObject valveFix;
    public GameObject valveOut;
    public GameObject valveChange;

    void Start()
    {
        valveChange.GetComponent<GameObject>();
        valveFix.GetComponent<GameObject>();
        valveOut.GetComponent<GameObject>();
    }
    void Update()
    {
        valveChange.transform.Rotate(0.0f, 0.5f, 0.0f, Space.Self);
    }
}
