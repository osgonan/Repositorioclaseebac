using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaScript : MonoBehaviour
{
    public GameObject capsula;
    // Update is called once per frame
    void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        capsula.GetComponent<MeshRenderer>().material.color = c;
    }

}
