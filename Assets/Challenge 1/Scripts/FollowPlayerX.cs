
/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    //Cámara
    private Vector3 offset = new Vector3(30,0,10);

    // Se llama al inicio para poder actualizar el cuadro
    void Start()
    {

    }

    // actualizaciones por cuadro
    void Update()
    {
        transform.position = plane.transform.position + offset ;
    }
}
