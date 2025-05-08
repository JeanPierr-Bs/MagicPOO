using System;
using UnityEngine;

public class Agente2 : PortadorJugable
{
    public Agente2(string nombre, Estadistica vida, Mana mana, SistemaHabilidades sistema)
        : base(nombre, vida, mana, sistema) { }

    public void UsarHabilidadConMana(TipoHabilidad tipo, int costoMana)
    {
        Mana.ConsumirMana(costoMana);
        UsarHabilidad(tipo);
    }
}
