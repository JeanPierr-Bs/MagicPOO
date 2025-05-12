using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    //public int cantidadDanio = 10;
    //public float intervaloDanio = 1.0f; // segundos entre cada daño

    //private float tiempoSiguienteDanio = 0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"💥 Estas dentro de la zona de daño: {other.name}");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, GetComponent<BoxCollider>().size);
    }
}