using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabEsferaUpdate : MonoBehaviour
{
    public GameObject Esfera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate(Esfera, new Vector3(5, 5, 5), Quaternion.identity);
        ///GameObject tempGameObject = Instantiate<GameObject>(Esfera);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}
