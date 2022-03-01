using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnableDisable : MonoBehaviour
{

    public GameObject caja;

    private void OnEnable()
    {
        GameObject temp = Instantiate(caja);
        temp.transform.position = Random.insideUnitSphere;
    }

    private void OnDisable()
    {
        GameObject temp = Instantiate(caja);
        temp.transform.position = Random.insideUnitSphere;
    }
}
