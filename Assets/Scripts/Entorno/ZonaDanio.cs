using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    public int cantidadDanio = 5;
    private void OnTriggerEnter(Collider other)
    {
        Test test = other.GetComponent<Test>();
        // Verificamos si entró un Agente1 simulando con su nombre
        if (test != null)
        {
            test.Agente.RecibirDaño(cantidadDanio);
            Debug.Log($"Zona de daño activada: se aplicaron {cantidadDanio} puntos de daño.");
        }
    }
    private void Update()
    {
        //ActualizarUI();
    }
   
}
