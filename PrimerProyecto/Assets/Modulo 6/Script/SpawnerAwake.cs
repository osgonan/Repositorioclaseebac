using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAwake : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject caja;
    void Awake()
    {
        GameObject temp = Instantiate(caja);
        temp.transform.position = Random.insideUnitSphere;
    }


}
