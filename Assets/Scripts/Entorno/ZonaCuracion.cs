using UnityEngine;

public class ZonaCuracion : MonoBehaviour
{
    //protected override void AplicarEfecto(IAfectarVida objetivo) => objetivo.Curar(Mathf.Abs(cantidad));
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"💥 Estas dentro de la zona de de carga de mana: {other.name}");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        SphereCollider col = GetComponent<SphereCollider>();
        if (col != null)
        {
            // Calcula la posición real del centro del collider
            Vector3 centro = transform.position + col.center;
            Gizmos.DrawWireSphere(centro, col.radius * transform.localScale.x);
        }
    }
}
