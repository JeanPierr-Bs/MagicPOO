using UnityEngine;

public class CamaraController : MonoBehaviour
{
    [Header("Objetivo a seguir")]
    public Transform objetivo;

    [Header("Offset")]
    public Vector3 offset = new Vector3(0f, 5f, -7f);

    [Header("Suavizado de seguimiento")]
    public float suavizado = 5f;

    [Header("Rotación con mouse")]
    public float sensibilidadX = 120f;
    public float sensibilidadY = 80f;
    public float minY = -30f;
    public float maxY = 60f;

    private float rotacionActualY = 0f;
    private float rotacionActualX = 0f;

    void Start()
    {
        Vector3 angulos = transform.eulerAngles;
        rotacionActualX = angulos.x;
        rotacionActualY = angulos.y;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        if (objetivo == null) return;

        // Movimiento de cámara con el mouse
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadY * Time.deltaTime;

        rotacionActualY += mouseX;
        rotacionActualX -= mouseY;
        rotacionActualX = Mathf.Clamp(rotacionActualX, minY, maxY);

        Quaternion rotacion = Quaternion.Euler(rotacionActualX, rotacionActualY, 0f);
        Vector3 posicionDeseada = objetivo.position + rotacion * offset;

        // Movimiento suave
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
        transform.LookAt(objetivo.position + Vector3.up * 1.5f); // Mira al personaje un poco más arriba del centro
    }
}
