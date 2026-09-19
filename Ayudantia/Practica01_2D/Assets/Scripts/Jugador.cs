using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Colision con: " + col.gameObject.name);
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("Manteniendo colision con: " + col.gameObject.name);
    }
}
