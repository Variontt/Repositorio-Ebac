using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea07Script01 : MonoBehaviour
{
    bool miBoleana;
    public GameObject prefabCubo;

    // Start is called before the first frame update
    void Start()
    {
        GameObject CreadorDeMiObjeto = Instantiate(prefabCubo, new Vector3(0, 0, 0), Quaternion.identity);

        CreadorDeMiObjeto.GetComponent<Renderer>().material.color = Color.red; 


        miBoleana = true;

        if (miBoleana)
        {
            CreadorDeMiObjeto.GetComponent<Renderer>().material.color = Color.white;
            miBoleana = false;           
        }

        Debug.Log(miBoleana);
      





    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
