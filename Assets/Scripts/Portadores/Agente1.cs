using System;
using UnityEngine;

public class Agente1 : PortadorJugable
{
    public Agente1(string nombre, string icono, Estadistica vida, Mana mana, SistemaHabilidades sistema)
        : base(nombre, icono, vida, mana, sistema) { }

    public void UsarHabilidadConVida(TipoHabilidad tipo, int costoVida)
    {
        RecibirDaño(costoVida);
        UsarHabilidad(tipo);
    }
}
