/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    // Inicia los frame
    void Start()
    {

    }

    // Actualizar por cuadro
    void FixedUpdate()
    {
        // Entrada vertical y horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Mover el avion hacia adelante a velocidad constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Mover el avión hacia arriba o hacia abajo
      transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput * verticalInput);

     
    }
}
