using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea07Script05 : MonoBehaviour
{
    public GameObject prefabCubo;

    bool Booleana01;
    bool Booleana02;
    bool Booleana03;

    // Start is called before the first frame update
    void Start()
    {

        GameObject CreadorDeMiObjeto = Instantiate(prefabCubo, new Vector3(0, 0, 0), Quaternion.identity);
        CreadorDeMiObjeto.GetComponent<Renderer>().material.color = Color.red;


        Booleana01 = true;
        Booleana02 = false;
        Booleana03 = true;

        if ((Booleana01 && !Booleana02) || Booleana03 == true)
        {
            CreadorDeMiObjeto.GetComponent<Renderer>().material.color = Color.white;
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
