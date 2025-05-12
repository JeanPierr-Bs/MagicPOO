using UnityEngine;

public class PortadorAdaptable : MonoBehaviour, IAfectarVida
{
    public Portador portador; // Se asigna desde fuera (ej. en Start o Inspector)

    public void Curar(int cantidad)
    {
        if (portador != null)
            portador.Curar(cantidad);
    }

    public void RecibirDa�o(int cantidad)
    {
        if (portador != null)
            portador.RecibirDa�o(cantidad);
    }
}
