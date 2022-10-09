using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea07Script03 : MonoBehaviour
{
    public GameObject prefabCubo;

    bool mi_Bolena01;
    bool mi_Boleana02;
    bool mi_Boleana03;



    // Start is called before the first frame update
    void Start()
    {
        GameObject CreadorDeMiObjeto = Instantiate(prefabCubo, new Vector3(0, 0, 0), Quaternion.identity);
        CreadorDeMiObjeto.GetComponent<Renderer>().material.color = Color.red;

        mi_Bolena01 = true;
        mi_Boleana02 = true;

        if (mi_Bolena01 || !mi_Boleana02)
        {
            CreadorDeMiObjeto.GetComponent<Renderer>().material.color = Color.white;
            mi_Boleana03 = true;
        }

        Debug.Log(mi_Boleana03);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
