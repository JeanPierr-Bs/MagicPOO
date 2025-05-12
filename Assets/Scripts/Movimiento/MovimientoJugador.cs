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
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        // Detectar punto donde apunta el mouse
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100f, capaSuelo))
        {
            Vector3 puntoObjetivo = hit.point;
            Vector3 direccion = puntoObjetivo - transform.position;
            direccion.y = 0f;

            if (direccion != Vector3.zero)
            {
                Quaternion rotacion = Quaternion.LookRotation(direccion);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, Time.deltaTime * 10f);
            }
        }

        // Movimiento con teclado
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direccionMovimiento = (transform.forward * vertical + transform.right * horizontal).normalized;

        // Solicitar salto
        if (Input.GetButtonDown("Jump") && estaEnSuelo)
            saltoSolicitado = true;
    }

    void FixedUpdate()
    {
        // Verificación de suelo
        estaEnSuelo = Physics.CheckSphere(puntoChequeoSuelo.position, radioChequeoSuelo, capaSuelo);

        // Movimiento
        Vector3 velocidad = direccionMovimiento * velocidadMovimiento;
        rb.linearVelocity = new Vector3(velocidad.x, rb.linearVelocity.y, velocidad.z);

        // Salto
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
