using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCapsula : MonoBehaviour
{
    public GameObject Capsula;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject tempGameObject = Instantiate(Capsula, new Vector3(2, 2, 2), Quaternion.identity);
        
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}
