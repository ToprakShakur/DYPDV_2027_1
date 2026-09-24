
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    // ---------------------------------
    // Movimiento horizontal
    // ---------------------------------

    public float velocidadActual = 0f;
    public float velocidadMax = 5f;
    public float aceleracion = 10f;
    public float desaceleracion = 8f;

    // ---------------------------------
    // Movimiento vertical
    // ---------------------------------

    public float velocidadVertical = 0f;
    public float gravedad = -20f;
    public float gravedadCaida = -30f;
    public float fuerzaSalto = 10f;

    // ---------------------------------
    // Salto
    // ---------------------------------

    public float tiempoMaxSalto = 0.2f;
    private float tiempoSaltoActual = 0f;

    // Coyote Time
    public float tiempoCoyote = 0.1f;
    private float coyoteTimer = 0f;

    // Jump Buffer
    public float tiempoBufferSalto = 0.1f;
    private float bufferTimer = 0f;

    // ---------------------------------
    // Animaciones
    // ---------------------------------

    public bool estaCaminando;
    public bool estaSaltando;
    public bool estaCayendo;

    // ---------------------------------
    // Tiempo
    // ---------------------------------

    private float tiempoAnterior;

    // ---------------------------------
    // Referencia al jugador
    // ---------------------------------

    private Jugador jugador;

    private void Awake()
    {
        jugador = GetComponent<Jugador>();
    }

    private void Start()
    {
        tiempoAnterior = Time.time;
    }

    private void Update()
    {
        // ---------------------------------
        // DeltaTime manual
        // ---------------------------------

        float delta = Time.time - tiempoAnterior;
        tiempoAnterior = Time.time;

        // ---------------------------------
        // Movimiento horizontal
        // ---------------------------------

        float h = Input.GetAxis("Horizontal");

        // Aceleración
        velocidadActual += h * aceleracion * delta;

        // Limitar velocidad
        velocidadActual = Mathf.Clamp(
            velocidadActual,
            -velocidadMax,
            velocidadMax
        );

        // ---------------------------------
        // Desaceleración automática
        // ---------------------------------

        if (h == 0)
        {
            if (velocidadActual > 0)
                velocidadActual -= desaceleracion * delta;

            else if (velocidadActual < 0)
                velocidadActual += desaceleracion * delta;

            // Evitar velocidades muy pequeñas
            if (Mathf.Abs(velocidadActual) < 0.1f)
                velocidadActual = 0;
        }

        // ---------------------------------
        // Coyote Time
        // ---------------------------------

        if (jugador.enSuelo)
            coyoteTimer = tiempoCoyote;
        else
            coyoteTimer -= delta;

        // ---------------------------------
        // Jump Buffering
        // ---------------------------------

        if (Input.GetAxis("Jump") > 0)
            bufferTimer = tiempoBufferSalto;
        else
            bufferTimer -= delta;

        // ---------------------------------
        // Salto con Coyote Time + Buffer
        // ---------------------------------

        if (bufferTimer > 0 && coyoteTimer > 0)
        {
            velocidadVertical = fuerzaSalto;

            jugador.enSuelo = false;

            bufferTimer = 0;
            coyoteTimer = 0;

            tiempoSaltoActual = 0f;
        }

        // ---------------------------------
        // Salto prolongado
        // ---------------------------------

        if (!jugador.enSuelo &&
            Input.GetAxis("Jump") > 0)
        {
            if (tiempoSaltoActual < tiempoMaxSalto)
            {
                velocidadVertical += 20f * delta;
                tiempoSaltoActual += delta;
            }
        }

        // ---------------------------------
        // Soltar botón de salto
        // ---------------------------------

        if (Input.GetAxis("Jump") == 0)
        {
            tiempoSaltoActual = tiempoMaxSalto;
        }

        // ---------------------------------
        // Gravedad mejorada
        // ---------------------------------

        if (jugador.enSuelo)
        {
            velocidadVertical = 0f;
        }
        else
        {
            if (velocidadVertical < 0)
                velocidadVertical += gravedadCaida * delta;
            else
                velocidadVertical += gravedad * delta;
        }

        // ---------------------------------
        // Movimiento final
        // ---------------------------------

        transform.position += new Vector3(
            velocidadActual * delta,
            velocidadVertical * delta,
            0
        );

        // ---------------------------------
        // Estados para animaciones
        // ---------------------------------

        estaCaminando = Mathf.Abs(velocidadActual) > 0.1f;
        estaSaltando = velocidadVertical > 0.1f;
        estaCayendo = velocidadVertical < -0.1f;
    }
}

