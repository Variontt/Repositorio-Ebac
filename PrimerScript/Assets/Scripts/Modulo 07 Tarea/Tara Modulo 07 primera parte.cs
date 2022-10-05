using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaraModulo07primeraparte : MonoBehaviour
{
    public GameObject Game_Object_GO;

    bool valorGo01;

    // Start is called before the first frame update
    void Start()
    {
        valorGo01 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject tempgameObject = Instantiate(Game_Object_GO, new Vector3(0, 0, 0), Quaternion.identity);
        tempgameObject.GetComponent<MeshRenderer>().material.color = Color.white;

        if (Game_Object_GO = )
        {
            
        }
    }
}
