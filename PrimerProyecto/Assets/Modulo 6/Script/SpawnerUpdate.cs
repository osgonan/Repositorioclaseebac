using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUpdate : MonoBehaviour
{
    public GameObject caja;
    // Update is called once per frame
    void Update()
    {
       GameObject temp =  Instantiate(caja);
        temp.transform.position = Random.insideUnitSphere;
    }
}
