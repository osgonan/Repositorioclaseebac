using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Metodo Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Metodo Start");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Metodo FixedUpdate");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Metodo Update");
    }

    private void LateUpdate()
    {
        Debug.LogAssertion("Metodo LateUpdate");
    }
}
