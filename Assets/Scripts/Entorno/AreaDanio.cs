using UnityEngine;

public class AreaDanio : MonoBehaviour
{
    public int daño;
    public float duracion;
    private float radio;
    private Portador portador;

    public void Inicializar(int daño, float duracion, float radio, Portador portador)
    {
        this.daño = daño;
        this.duracion = duracion;
        this.radio = radio;
        this.portador = portador;

        // Escala visual del área (opcional)
        transform.localScale = Vector3.one * radio;

        // Destruye el objeto tras la duración
        Destroy(gameObject, duracion);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Supón que los enemigos tienen un componente "Enemigo" con método RecibirDaño
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<PortadorNoJugable>()?.RecibirDaño(daño);
        }
    }
}
