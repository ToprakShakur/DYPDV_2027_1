using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
    public bool enSuelo = false;

    protected override void Awake()
    {
        base.Awake();

        // Aquí puedes añadir inicialización extra del jugador
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Tocó suelo");
            enSuelo = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Suelo"))
        {
            enSuelo = false;
        }
    }

    public override void RecibirDaño(int cantidad)
    {
        base.RecibirDaño(cantidad);
        Debug.Log("¡El jugador recibió daño!");
    }
}
