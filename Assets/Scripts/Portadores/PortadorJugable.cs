using System;
using System.Collections;
using UnityEngine;

public class PortadorJugable : Portador
{
    public string Icono { get; set; }
    public Mana Mana { get; set; }
    public SistemaHabilidades SistemaHabilidades { get; set; }
   
    private bool estaMuerto = false;

    //public PortadorJugable(string nombre, string icono, Estadistica vida, Mana mana, SistemaHabilidades sistemaHabilidades)
    //    : base(nombre, vida)
    //{
    //    Mana = mana;
    //    SistemaHabilidades = sistemaHabilidades;
    //}

    public void Inicializar(string nombre, string icono, Estadistica vida, Mana mana, SistemaHabilidades sistemaHabilidades)        
    {
        Mana = mana;
        SistemaHabilidades = sistemaHabilidades;
    }


    public void UsarHabilidad(TipoHabilidad tipo)
    {
        var habilidd = SistemaHabilidades.Habilidades[0];

        foreach (var habilidad in SistemaHabilidades.Habilidades)
        {
            if (habilidad.Tipo == tipo)
            {
                SistemaHabilidades.LanzarHabilidad(tipo);
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