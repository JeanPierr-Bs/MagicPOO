using System;
using Unity.VisualScripting;
using UnityEngine;

public class Agente1 : PortadorJugable
{
    #region Variables UI

    [SerializeField]
    public string nombreAgente;

    [SerializeField]
    public string icono;

    [SerializeField]
    public Mana Mana;

    [SerializeField]
    public SistemaHabilidades SistemaHabilidades;

    #endregion

    //public Agente1(string nombre, string icono, Estadistica vida, Mana mana, SistemaHabilidades sistema)
    //    : base(nombre, icono, vida, mana, sistema) { }

    public void UsarHabilidadConVida(TipoHabilidad tipo, int costoVida)
    {
        RecibirDaño(costoVida);
        UsarHabilidad(tipo);
    }
}
