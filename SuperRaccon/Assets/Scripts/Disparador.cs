using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject balaPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            var bala = Instantiate(balaPrefab,
                transform.position + new Vector3(2,0,0),
                balaPrefab.transform.rotation
            );
        }
    }
}
