using System;
using UnityEngine;

public class PortadorNoJugable : Portador
{
    public PortadorNoJugable(string nombre, Estadistica vida)
        : base(nombre, vida) { }

    public void VerificarMuerte()
    {
        if (Vida.ValorActual <= 0)
        {
            AlMorir();
        }
    }

    private void AlMorir()
    {
        Debug.Log($"{Nombre} ha sido destruido.");
    }
}