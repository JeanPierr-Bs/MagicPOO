using System;
using System.Collections;
using UnityEngine;

public class PortadorJugable : Portador
{
    public string Icono { get; set; }
    public Mana Mana { get; set; }
    public SistemaHabilidades SistemaHabilidades { get; set; }
    public Transform PuntoDisparo { get; set; } // Asignado desde Test o vía Inspector



    private bool estaMuerto = false;

    public PortadorJugable(string nombre, string icono, Estadistica vida, Mana mana, SistemaHabilidades sistemaHabilidades)
        : base(nombre, vida)
    {
        Mana = mana;
        SistemaHabilidades = sistemaHabilidades;
    }
    public void UsarHabilidad(TipoHabilidad tipo)
    {
        foreach (var habilidad in SistemaHabilidades.Habilidades)
        {
            if (habilidad.Tipo == tipo)
            {
                habilidad.Portador = this; // ✅ ASIGNACIÓN NECESARIA
                //SistemaHabilidades.LanzarHabilidad(tipo);
                habilidad.Usar();
            }
        }
    }
    public void VerificarMuerte()
    {
        if (Vida.ValorActual <= 0 && !estaMuerto)
        {
            estaMuerto = true;
            AlMorir();
        }
    }

    private void AlMorir()
    {
        Debug.Log($"{Nombre} ha sido destruido.");
    }
}