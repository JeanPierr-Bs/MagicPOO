using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    public int cantidadDanio = 5;
    private void OnTriggerEnter(Collider other)
    {
        Test test = other.GetComponent<Test>();
        // Verificamos si entr� un Agente1 simulando con su nombre
        if (test != null)
        {
            test.Agente.RecibirDa�o(cantidadDanio);
            Debug.Log($"Zona de da�o activada: se aplicaron {cantidadDanio} puntos de da�o.");
        }
    }
    private void Update()
    {
        //ActualizarUI();
    }
   
}
