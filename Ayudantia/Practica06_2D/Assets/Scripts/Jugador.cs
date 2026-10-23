using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
    public bool enSuelo = false;

    public GameObject prefabProyectil;
    public Transform puntoDisparo;

    public AudioSource audioSrc;
    public AudioClip sonidoDisparo;

    protected override void Awake()
    {
        base.Awake();

        // Aquí puedes añadir inicialización extra del jugador
    }


    protected override void Update()
    {
        base.Update();

        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        
        Debug.Log("Prefab: " + prefabProyectil);
        Debug.Log("PuntoDisparo: " + puntoDisparo);

        GameObject p = Instantiate(
            prefabProyectil,
            puntoDisparo.position,
            Quaternion.identity
        );

        Vector2 dir = (transform.localScale.x < 0)
            ? Vector2.left
            : Vector2.right;

        float velocidadJugador = velocidadActual;

        p.GetComponent<Proyectil>().Inicializar(dir, velocidadJugador);

        audioSrc.PlayOneShot(sonidoDisparo);
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
