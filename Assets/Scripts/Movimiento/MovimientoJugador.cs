using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class MovimientoJugador : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidadMovimiento = 5f;

    [Header("Salto")]
    public float fuerzaSalto = 7f;
    public Transform puntoChequeoSuelo;
    public float radioChequeoSuelo = 0.3f;
    public LayerMask capaSuelo;

    private Rigidbody rb;
    private Vector3 direccionMovimiento;
    private bool saltoSolicitado = false;
    private bool estaEnSuelo;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void Update()
    {
        // Movimiento básico
        direccionMovimiento = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
            direccionMovimiento += transform.forward;
        if (Keyboard.current.sKey.isPressed)
            direccionMovimiento -= transform.forward;
        if (Keyboard.current.dKey.isPressed)
            direccionMovimiento += transform.right;
        if (Keyboard.current.aKey.isPressed)
            direccionMovimiento -= transform.right;

        direccionMovimiento = direccionMovimiento.normalized;

        // Solicitar salto
        if (Keyboard.current.spaceKey.wasPressedThisFrame && estaEnSuelo)
            saltoSolicitado = true;
    }

    void FixedUpdate()
    {
        // Verificación de suelo
        estaEnSuelo = Physics.CheckSphere(puntoChequeoSuelo.position, radioChequeoSuelo, capaSuelo);

        // Movimiento
        Vector3 velocidadHorizontal = direccionMovimiento * velocidadMovimiento;
        rb.linearVelocity = new Vector3(velocidadHorizontal.x, rb.linearVelocity.y, velocidadHorizontal.z);

        // Salto directo
        if (saltoSolicitado)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, fuerzaSalto, rb.linearVelocity.z);
            saltoSolicitado = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        if (puntoChequeoSuelo != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(puntoChequeoSuelo.position, radioChequeoSuelo);
        }
    }
}
