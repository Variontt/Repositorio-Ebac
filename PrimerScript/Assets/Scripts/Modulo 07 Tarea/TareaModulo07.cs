using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaModulo07 : MonoBehaviour
{
    public GameObject Game_Object_GO;

    bool valorGo01;
    bool valorGo02;

   // int valor01 = 1;

   // int LimiteInferior = 0;
   //int LimiteSuperior = 1;


    // Start is called before the first frame update
    void Start()
    {
        
       

        

        //valor01 = Random.Range(LimiteInferior, LimiteSuperior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        valorGo01 = true;
        if (valorGo01 == true)
        {
            GameObject tempgameObject = Instantiate(Game_Object_GO, new Vector3(0, 0, 0), Quaternion.identity);
            tempgameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }


    }
}
