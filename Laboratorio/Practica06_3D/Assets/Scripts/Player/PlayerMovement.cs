using UnityEngine;

public class PlayerMovementAnim : MonoBehaviour
{
    Animator anim;
    CharacterController controller;

    // Referencia al CameraRig
    public Transform cameraTransform;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Direcciones de la cámara
        Vector3 camForward = cameraTransform.forward;
        Vector3 camRight = cameraTransform.right;

        camForward.y = 0f;
        camRight.y = 0f;

        camForward.Normalize();
        camRight.Normalize();

        // Movimiento relativo a la cámara
        Vector3 moveDir = camForward * z + camRight * x;

        // Movimiento del personaje
        controller.Move(moveDir * Time.deltaTime * 3f);

        // Parámetro para el Animator
        float speedValue = moveDir.magnitude;
        anim.SetFloat("Speed", speedValue);

        // Rotación hacia la dirección del movimiento
        if (moveDir.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDir);

            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                targetRotation,
                Time.deltaTime * 10f
            );
        }

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("IsJumping", true);
        }
        else
        {
            anim.SetBool("IsJumping", false);
        }
    }
}