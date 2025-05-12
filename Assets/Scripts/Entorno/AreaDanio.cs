using UnityEngine;

public class AreaDanio : MonoBehaviour
{
    public int da�o;
    public float duracion;
    private float radio;
    private Portador portador;

    public void Inicializar(int da�o, float duracion, float radio, Portador portador)
    {
        this.da�o = da�o;
        this.duracion = duracion;
        this.radio = radio;
        this.portador = portador;

        // Escala visual del �rea (opcional)
        transform.localScale = Vector3.one * radio;

        // Destruye el objeto tras la duraci�n
        Destroy(gameObject, duracion);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Sup�n que los enemigos tienen un componente "Enemigo" con m�todo RecibirDa�o
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<PortadorNoJugable>()?.RecibirDa�o(da�o);
        }
    }
}
