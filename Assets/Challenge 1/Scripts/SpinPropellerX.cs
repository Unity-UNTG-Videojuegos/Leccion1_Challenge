/*
Rosas Castillo Gabriela
Creación de videojuegos
Challenge 1 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propeller = 1000;

    void Start()
    {
        
    }

    // Actualización por frame
    void Update()
    {
     transform.Rotate(Vector3.forward, propeller * Time.deltaTime);
   
    }
}
