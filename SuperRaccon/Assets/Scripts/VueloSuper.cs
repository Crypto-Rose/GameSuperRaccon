using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueloSuper : MonoBehaviour
{
    public Vector2 FuerzaSalto;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().AddForce(FuerzaSalto);
        }
    }
}
