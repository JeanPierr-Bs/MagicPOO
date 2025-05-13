using UnityEngine;

public class Portador : MonoBehaviour, IAfectarVida
{
    public string Nombre { get; set; }
    public Estadistica Vida { get; set; }

    //public Portador(string nombre, Estadistica vida)
    //{
    //    Nombre = nombre;
    //    Vida = vida;
    //}

    public void Inicializar(string nombre, Estadistica vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public virtual void Curar(int cantidad) => Vida.AfectarEstadisticas(+cantidad);
    public virtual void RecibirDaño(int cantidad) => Vida.AfectarEstadisticas(-cantidad);
}
