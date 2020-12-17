using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverIzq : MonoBehaviour
{   
    public float velocidad;
    public Enemigo enemigo;

    private void Awake()
    {
        enemigo = GetComponent<Enemigo>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * velocidad);        
        if(transform.position.x < -11)
        {
            transform.position+= new Vector3(23,0,0);
            MostrarObjAleatorios();
            enemigo?.Nacer();
        }    
    }

    private void MostrarObjAleatorios()
    {
        int numRandom = UnityEngine.Random.Range(0,3);
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform hijo = transform.GetChild(i);
            bool mostrarHijo = numRandom == i;
            hijo.gameObject.SetActive(mostrarHijo); 
        }
    }

    private void OnEnable()
    {
        MostrarObjAleatorios();
    }

}

