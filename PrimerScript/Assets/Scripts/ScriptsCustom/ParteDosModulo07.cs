using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteDosModulo07 : MonoBehaviour
{
    public GameObject Cubo;


    bool verObjeto;


    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numcubos = 0;


    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

   
    void Update()
    {
        numcubos++;
        GameObject Prefab_GO = Instantiate<GameObject>(Cubo);
        Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.red;
        Prefab_GO.name = "Cubo Número " + numcubos;
        Prefab_GO.transform.position = Random.insideUnitSphere;

         verObjeto = true;
        Debug.Log(verObjeto);

        if (verObjeto) // En el IF statemente usae un boleano y no un intergear como el inciso pasado
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

            if (escala <= 0.42)
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

