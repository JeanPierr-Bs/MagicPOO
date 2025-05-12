using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    public int cantidadDanio = 10;
    public float intervaloDanio = 1.0f; // segundos entre cada daño

    private float tiempoSiguienteDanio = 0f;

    private void OnTriggerStay(Collider other)
    {
        Agente1 agente = other.GetComponent<Agente1>();

        if (agente != null)
        {
            if (Time.time >= tiempoSiguienteDanio)
            {
                agente.RecibirDaño(cantidadDanio);
                Debug.Log($" Zona de daño constante: {agente.Nombre} recibió {cantidadDanio} puntos de daño.");
                tiempoSiguienteDanio = Time.time + intervaloDanio;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Reinicia el temporizador cuando el jugador sale
        if (other.GetComponent<Agente1>() != null)
        {
            tiempoSiguienteDanio = 0f;
            Debug.Log(" El jugador salió de la zona de daño.");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, GetComponent<BoxCollider>().size);
    }
}