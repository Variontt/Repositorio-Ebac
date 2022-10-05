using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public GameObject Cubo;

    bool valorGo01;
    bool valorGo02;

    int valor01 = 1;

    int LimiteInferior = -5;
    int LimiteSuperior = 5;

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
        numcubos++;
        GameObject Prefab_GO = Instantiate<GameObject>(Cubo);
        Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.red;
        Prefab_GO.name = "Cubo Número " + numcubos;
        Prefab_GO.transform.position = Random.insideUnitSphere;

        valor01 = Random.Range(LimiteInferior, LimiteSuperior);
        Debug.Log(valorGo01);

        if (valor01 >= 0)
        {
            Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            Prefab_GO.GetComponent<MeshRenderer>().material.color = Color.black;
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

