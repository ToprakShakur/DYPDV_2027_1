using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemigoIA : Personaje
{
    public float direccion = -1f; // -1 izquierda, 1 derecha

    protected override void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        rb.velocity = new Vector2(direccion * velocidad, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Pared") ||
            col.gameObject.CompareTag("Obstaculo"))
        {
            direccion *= -1;
            sr.flipX = !sr.flipX;
        }

        // Interaccion con el jugador
        if (col.gameObject.CompareTag("Player"))
        {
            if (col.contacts[0].normal.y < 0)
            {
                // El jugador cayo encima
                RecibirDaño(1);
            }
            else
            {
                // El jugador choco de lado
                col.gameObject.GetComponent<Jugador>().RecibirDaño(1);
            }
        }
    }
}