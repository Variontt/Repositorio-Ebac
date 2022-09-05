using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        
    }
    int x; 
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("algo paso");

        Debug.LogWarning("Algo salio medianamente Mal");
        Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto a sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto a sido inhabilitado");
    }
}
