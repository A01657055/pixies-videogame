using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{

public int tipoComida;


    // Start is called before the first frame update
    void Start()
    {
        tipoComida = Random.Range(1,5);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
