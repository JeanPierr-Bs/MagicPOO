using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private float velocidad;
    private int danio;
    private Portador portador;

    public void Inicializar(float velocidad, int danio, Portador portador)
    {
        this.velocidad = velocidad;
        this.danio = danio;
        this.portador = portador;
        Destroy(gameObject, 5f); // Destruir autom�ticamente despu�s de 5 segundos
    }

    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PortadorNoJugable enemigo) && enemigo != portador)
        {
            enemigo.RecibirDa�o(danio);
            Debug.Log($"{enemigo.name} recibi� {danio} de da�o por proyectil.");
            Destroy(gameObject);
        }
    }
}
