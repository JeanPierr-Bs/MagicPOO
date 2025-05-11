using UnityEngine;

public class CamaraController : MonoBehaviour
{
    [Header("Objetivo a seguir")]
    public Transform objetivo;

    [Header("Configuraci�n de c�mara")]
    public Vector3 offset = new Vector3(0f, 5f, -7f);
    public float suavizado = 5f;

    void LateUpdate()
    {
        if (objetivo == null) return;

        // Posici�n deseada basada en el offset relativo al personaje
        Vector3 posicionDeseada = objetivo.position + offset;

        // Interpolaci�n suave
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);

        // Mira al personaje (opcional)
        transform.LookAt(objetivo);
    }
}
