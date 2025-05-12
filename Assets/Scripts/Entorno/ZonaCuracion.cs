using UnityEngine;

public class ZonaCuracion : MonoBehaviour
{
    //protected override void AplicarEfecto(IAfectarVida objetivo) => objetivo.Curar(Mathf.Abs(cantidad));
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si entró un Agente1 simulando con su nombre
        if (other.CompareTag("Player")) // Usa esta tag si ya la asignaste en tu personaje
        {
            Debug.Log("El personaje ha entrado en la zona de curacion de Mana. Habilidad de daño activada.");
        }
    }
}
