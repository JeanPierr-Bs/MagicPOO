using UnityEngine;

public class CamaraController : MonoBehaviour
{
    [Header("Referencia del jugador")]
    public Transform cabezaJugador;

    [Header("Sensibilidad del mouse")]
    public float sensibilidadX = 120f;
    public float sensibilidadY = 80f;
    public float minY = -60f;
    public float maxY = 60f;

    private float rotacionY = 0f;
    private float rotacionX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadY * Time.deltaTime;

        rotacionY += mouseX;
        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX, minY, maxY);

        cabezaJugador.localRotation = Quaternion.Euler(rotacionX, 0f, 0f); // mirar arriba/abajo
        transform.rotation = Quaternion.Euler(0f, rotacionY, 0f); // girar cuerpo
    }
}
