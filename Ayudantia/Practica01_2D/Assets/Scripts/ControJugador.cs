using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    void Update()
    {
        // Movimiento horizontal (teclas A/D o flechas izquierda/derecha)
        float h = Input.GetAxis("Horizontal");
        if (h != 0)
        {
            Debug.Log("Movimiento horizontal: " + h);
        }

        // Salto (tecla Espacio)
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Salto detectado");
        }
    }
}
