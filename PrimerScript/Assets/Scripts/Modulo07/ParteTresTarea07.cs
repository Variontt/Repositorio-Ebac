using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteTresTarea07 : MonoBehaviour
{
    public GameObject cubo01;
    public GameObject cubo02;
    public GameObject cubo03;

    bool Boleana01;
    bool Boleana02;
    bool Boleana03;


    int valor01 = 1;                // Intergers para el if
    int LimiteInferior = 0;
    int LimiteSuperior = 3;
    // Start is called before the first frame update
    void Start()
    {
        valor01 = Random.Range(LimiteInferior, LimiteSuperior);
        Debug.Log(valor01);
        Boleana01 = true;
        Boleana02 = false;
        Boleana03 = true;
        
        if ((!Boleana01 && !Boleana02) || Boleana03)
        {
            GameObject PrimerGo = Instantiate(cubo01, new Vector3(-5, 0, 0), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
    }

}
