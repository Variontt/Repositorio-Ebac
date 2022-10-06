using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteUnoTarea07 : MonoBehaviour
{
    public GameObject Cubo;

  

    int valor01 = 1;

    int LimiteInferior = -1;
    int LimiteSuperior = 1;

    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numcubos = 0;

    // Start is called before the first frame update
    void Start()
    {


        listaDeCubos = new List<GameObject>();




    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        // ----------- Creador de varios cubos del prefab con Color rojo ---------------------
        numcubos++;
        GameObject Prefab_GO = Instantiate<GameObject>(Cubo);
        Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.red;
        Prefab_GO.name = "Cubo Número " + numcubos;
        Prefab_GO.transform.position = Random.insideUnitSphere;
        // ------------------------------------------------------------------------



        //------------ variable de datos radom entre -1 y 1---------
        valor01 = Random.Range(LimiteInferior, LimiteSuperior);
        Debug.Log(valor01);
        //--------------------------------------------




        // ----------- Condicional con valor 1 
        if (valor01 < 0)
        {
            Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else
        {
            Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        listaDeCubos.Add(Prefab_GO);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;

            if (escala <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}

